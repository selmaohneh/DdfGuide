using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class RoleListAdapter : BaseAdapter<RoleDto>
    {
        private readonly Activity _context;
        private IEnumerable<RoleDto> _roles;

        public RoleListAdapter(Activity context)
        {
            _context = context;
            _roles = new List<RoleDto>();
        }

        public void SetRoles(IEnumerable<RoleDto> roles)
        {
            _roles = roles;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var role = _roles.ElementAt(position);
            var view = convertView;

            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.roleslistitem, null);
            }

            view.FindViewById<TextView>(Resource.Id.textviewcharacter).Text = role.Character;
            view.FindViewById<TextView>(Resource.Id.textviewspeaker).Text = role.Speaker;

            return view;
        }

        public override int Count => _roles.Count();

        public override RoleDto this[int position] => _roles.ElementAt(position);
    }
}