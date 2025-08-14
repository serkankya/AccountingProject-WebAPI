using Project.Domain.MainEntities;
using Project.Domain.MainEntities.Identity;

namespace Project.Domain.Roles
{
	public sealed class RoleList
	{
		public static List<AppRole> GetStaticRoles()
		{
			List<AppRole> appRoles = new List<AppRole>
			{
				new AppRole
				{
					Title = UCOA,
					Name = UCOACreateName,
					Code = UCOACreateCode
				},

				new AppRole
				{
					Title = UCOA,
					Name = UCOAUpdateName,
					Code = UCOAUpdateCode
				},

				new AppRole
				{
					Title = UCOA,
					Name = UCOADeleteName,
					Code = UCOADeleteCode
				},

				new AppRole
				{
					Title = UCOA,
					Name = UCOAReadName,
					Code = UCOAReadCode
				}
			};

			return appRoles;
		}

		public static List<MainRole> GetStaticMainRoles()
		{
			List<MainRole> mainRoles = new List<MainRole>
			{
				new MainRole(
					id: Guid.NewGuid().ToString(),
					title: "Admin",
					isRoleCreatedByAdmin: true),

				new MainRole(
					id: Guid.NewGuid().ToString(),
					title: "Manager",
					isRoleCreatedByAdmin: true),

				new MainRole(
					id: Guid.NewGuid().ToString(),
					title: "User",
					isRoleCreatedByAdmin: true)
			};

			return mainRoles;
		}

		public static string UCOA = "Hesap Planı";

		public static string UCOACreateCode = "UCOA.Create";
		public static string UCOACreateName = "Hesap Planı Kayıt";

		public static string UCOAUpdateCode = "UCOA.Update";
		public static string UCOAUpdateName = "Hesap Planı Güncelle";

		public static string UCOADeleteCode = "UCOA.Delete";
		public static string UCOADeleteName = "Hesap Planı Sil";

		public static string UCOAReadCode = "UCOA.Read";
		public static string UCOAReadName = "Hesap Planı Görüntüle";
	}
}
