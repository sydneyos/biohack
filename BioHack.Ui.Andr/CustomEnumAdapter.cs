using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using BioHack.Core.Andr.Domain;

namespace BioHack.Ui.Andr
{
    public class CustomEnumAdapter : BaseAdapter
    {
        private readonly Activity _context;
        private readonly IList<ICustomEnum> _enums;
        private readonly IList<View> _views = new List<View>();

        public CustomEnumAdapter(Activity context, IList<ICustomEnum> data)
        {
            _context = context;
            _enums = data;
        }

        public ICustomEnum GetItemAtPosition(int position)
        {
            return _enums[position];
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int id)
        {
            return id;
        }

        public override int Count
        {
            get
            {
                return _enums == null ? 0 : _enums.Count;
            }
        }

        public override View GetDropDownView(int position, View convertView, ViewGroup parent)
        {
            return GetCustomView(position, convertView, parent, true);
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            return GetCustomView(position, convertView, parent, false);
        }

        private View GetCustomView(int position, View convertView, ViewGroup parent, bool dropdown)
        {
            var item = _enums[position];

            var inflater = LayoutInflater.From(_context);
            var view = convertView ?? inflater.Inflate((dropdown ? Resource.Layout.SpinnerItemDropdown : Resource.Layout.SpinnerItemText), parent, false);

            var text = view.FindViewById<TextView>(Resource.Id.Text);

            if (text != null)
                text.Text = item.Display;

            if (!_views.Contains(view))
                _views.Add(view);

            return view;
        }

        private void ClearViews()
        {
            foreach (var view in _views)
            {
                view.Dispose();
            }
            _views.Clear();
        }

        protected override void Dispose(bool disposing)
        {
            ClearViews();
            base.Dispose(disposing);
        }
    }
}