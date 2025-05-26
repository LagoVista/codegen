/* 5/6/2025 3:32:11 PM */
using System.Globalization;
using System.Reflection;

namespace LagoVista.UserAdmin.Models.Resources
{
	public class UserAdminResources
	{
		private static global::System.Resources.ResourceManager _resourceManager;   
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(_resourceManager, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LagoVista.UserAdmin.Models.Resources.UserAdminResources", typeof(UserAdminResources).GetTypeInfo().Assembly);
                                _resourceManager = temp;
                }
                return _resourceManager;
            }
        }
        /// <summary>
        ///   Returns the formatted resource string.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static string GetResourceString(string key, params string[] tokens)
        {
            var culture = CultureInfo.CurrentCulture; ;
            var str = ResourceManager.GetString(key, culture);

            for (int i = 0; i < tokens.Length; i += 2)
                str = str.Replace(tokens[i], tokens[i + 1]);

            return str;
        }
        /// <summary>
        ///   Returns the formatted resource string.
        /// </summary>
        /*
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static HtmlString GetResourceHtmlString(string key, params string[] tokens)
    	{
    		var str = GetResourceString(key, tokens);

    		if(str.StartsWith("HTML:"))
    			str = str.Substring(5);

    		return new HtmlString(str);
        }*/
		public static string Admin_Contact { get { return GetResourceString("Admin_Contact"); } }

		public static string AppUser_ConfirmPassword { get { return GetResourceString("AppUser_ConfirmPassword"); } }

		public static string AppUser_Description { get { return GetResourceString("AppUser_Description"); } }

		public static string AppUser_Email { get { return GetResourceString("AppUser_Email"); } }

		public static string AppUser_FirstName { get { return GetResourceString("AppUser_FirstName"); } }

		public static string AppUser_Help { get { return GetResourceString("AppUser_Help"); } }

		public static string AppUser_LastName { get { return GetResourceString("AppUser_LastName"); } }

		public static string AppUser_NewPassword { get { return GetResourceString("AppUser_NewPassword"); } }

		public static string AppUser_OldPassword { get { return GetResourceString("AppUser_OldPassword"); } }

		public static string AppUser_Password { get { return GetResourceString("AppUser_Password"); } }

		public static string AppUser_PasswordConfirmPasswordMatch { get { return GetResourceString("AppUser_PasswordConfirmPasswordMatch"); } }

		public static string AppUser_PhoneNumber { get { return GetResourceString("AppUser_PhoneNumber"); } }

		public static string AppUser_PhoneVerificationCode { get { return GetResourceString("AppUser_PhoneVerificationCode"); } }

		public static string AppUser_RememberMe { get { return GetResourceString("AppUser_RememberMe"); } }

		public static string AppUser_RememberMe_InThisBrowser { get { return GetResourceString("AppUser_RememberMe_InThisBrowser"); } }

		public static string AppUser_Title { get { return GetResourceString("AppUser_Title"); } }

		public static string Billing_Contact { get { return GetResourceString("Billing_Contact"); } }

		public static string Common_CreatedBy { get { return GetResourceString("Common_CreatedBy"); } }

		public static string Common_CreationDate { get { return GetResourceString("Common_CreationDate"); } }

		public static string Common_Description { get { return GetResourceString("Common_Description"); } }

		public static string Common_EmailAddress { get { return GetResourceString("Common_EmailAddress"); } }

		public static string Common_Id { get { return GetResourceString("Common_Id"); } }

		public static string Common_LastUpdatedBy { get { return GetResourceString("Common_LastUpdatedBy"); } }

		public static string Common_LastUpdatedDate { get { return GetResourceString("Common_LastUpdatedDate"); } }

		public static string Common_Namespace { get { return GetResourceString("Common_Namespace"); } }

		public static string Common_Notes { get { return GetResourceString("Common_Notes"); } }

		public static string Common_PhoneNumber { get { return GetResourceString("Common_PhoneNumber"); } }

		public static string Common_Role { get { return GetResourceString("Common_Role"); } }

		public static string Common_Status { get { return GetResourceString("Common_Status"); } }

		public static string GeoLocation_Description { get { return GetResourceString("GeoLocation_Description"); } }

		public static string GeoLocation_Help { get { return GetResourceString("GeoLocation_Help"); } }

		public static string GeoLocation_Title { get { return GetResourceString("GeoLocation_Title"); } }

		public static string ImageDetails_Description { get { return GetResourceString("ImageDetails_Description"); } }

		public static string ImageDetails_Help { get { return GetResourceString("ImageDetails_Help"); } }

		public static string ImageDetails_Title { get { return GetResourceString("ImageDetails_Title"); } }

		public static string InuteUser_Status_Declined { get { return GetResourceString("InuteUser_Status_Declined"); } }

		public static string Invitation_Description { get { return GetResourceString("Invitation_Description"); } }

		public static string Invitation_Help { get { return GetResourceString("Invitation_Help"); } }

		public static string Invitation_Title { get { return GetResourceString("Invitation_Title"); } }

		public static string InviteUser_AlreadyPartOfOrg { get { return GetResourceString("InviteUser_AlreadyPartOfOrg"); } }

		public static string InviteUser_ClickHere { get { return GetResourceString("InviteUser_ClickHere"); } }

		public static string InviteUser_Greeting_Label { get { return GetResourceString("InviteUser_Greeting_Label"); } }

		///<summary>
		///WIll replace [USERS_FULL_NAME] with the first/last name of current user, [ORG_NAME] as the name of the organization.
		///</summary>
		public static string InviteUser_Greeting_Message { get { return GetResourceString("InviteUser_Greeting_Message"); } }

		///<summary>
		///No need to translate
		///</summary>
		public static string InviteUser_InvitedById { get { return GetResourceString("InviteUser_InvitedById"); } }

		public static string InviteUser_InvitedByName { get { return GetResourceString("InviteUser_InvitedByName"); } }

		public static string InviteUser_Name { get { return GetResourceString("InviteUser_Name"); } }

		public static string InviteUser_Status { get { return GetResourceString("InviteUser_Status"); } }

		public static string InviteUser_Status_Accepted { get { return GetResourceString("InviteUser_Status_Accepted"); } }

		public static string InviteUser_Status_Queued { get { return GetResourceString("InviteUser_Status_Queued"); } }

		public static string Invite_Greeting_Subject { get { return GetResourceString("Invite_Greeting_Subject"); } }

		public static string LocationUserRole_Description { get { return GetResourceString("LocationUserRole_Description"); } }

		public static string LocationUserRole_Help { get { return GetResourceString("LocationUserRole_Help"); } }

		public static string LocationUserRole_Title { get { return GetResourceString("LocationUserRole_Title"); } }

		public static string LocationUser_Description { get { return GetResourceString("LocationUser_Description"); } }

		public static string LocationUser_Help { get { return GetResourceString("LocationUser_Help"); } }

		public static string LocationUser_Title { get { return GetResourceString("LocationUser_Title"); } }

		public static string LocationNamespace_Help { get { return GetResourceString("LocationNamespace_Help"); } }

		public static string Location_Address1 { get { return GetResourceString("Location_Address1"); } }

		public static string Location_Address2 { get { return GetResourceString("Location_Address2"); } }

		public static string Location_Admin_Contact { get { return GetResourceString("Location_Admin_Contact"); } }

		public static string Location_City { get { return GetResourceString("Location_City"); } }

		public static string Location_Country { get { return GetResourceString("Location_Country"); } }

		public static string Location_GeoLocation { get { return GetResourceString("Location_GeoLocation"); } }

		public static string Location_LocationName { get { return GetResourceString("Location_LocationName"); } }

		public static string Location_State { get { return GetResourceString("Location_State"); } }

		public static string Organization { get { return GetResourceString("Organization"); } }

		public static string OrganizationUserRole_Description { get { return GetResourceString("OrganizationUserRole_Description"); } }

		public static string OrganizationUserRole_Help { get { return GetResourceString("OrganizationUserRole_Help"); } }

		public static string OrganizationUserRole_Title { get { return GetResourceString("OrganizationUserRole_Title"); } }

		public static string OrganizationUser_CouldntAdd { get { return GetResourceString("OrganizationUser_CouldntAdd"); } }

		public static string OrganizationUser_UserExists { get { return GetResourceString("OrganizationUser_UserExists"); } }

		public static string OrganizationLocation_NamespaceInUse { get { return GetResourceString("OrganizationLocation_NamespaceInUse"); } }

		public static string OrganizationNamespace_Help { get { return GetResourceString("OrganizationNamespace_Help"); } }

		public static string Organization_User_Title { get { return GetResourceString("Organization_User_Title"); } }

		public static string Organization_User_Description { get { return GetResourceString("Organization_User_Description"); } }

		public static string Organization_User_Help { get { return GetResourceString("Organization_User_Help"); } }

		public static string Organization_CantCreate { get { return GetResourceString("Organization_CantCreate"); } }

		public static string Organization_Description { get { return GetResourceString("Organization_Description"); } }

		public static string Organization_Help { get { return GetResourceString("Organization_Help"); } }

		public static string Organization_Location { get { return GetResourceString("Organization_Location"); } }

		public static string Organization_Locations { get { return GetResourceString("Organization_Locations"); } }

		public static string Organization_Location_Description { get { return GetResourceString("Organization_Location_Description"); } }

		public static string Organization_Location_Help { get { return GetResourceString("Organization_Location_Help"); } }

		public static string Organization_Location_Title { get { return GetResourceString("Organization_Location_Title"); } }

		public static string Organization_Name { get { return GetResourceString("Organization_Name"); } }

		public static string Organization_NamespaceInUse { get { return GetResourceString("Organization_NamespaceInUse"); } }

		public static string Organization_Primary_Location { get { return GetResourceString("Organization_Primary_Location"); } }

		public static string Organization_Status_Active { get { return GetResourceString("Organization_Status_Active"); } }

		public static string Organization_Status_Active_BehindPayments { get { return GetResourceString("Organization_Status_Active_BehindPayments"); } }

		public static string Organization_Status_Archived { get { return GetResourceString("Organization_Status_Archived"); } }

		public static string Organization_Title { get { return GetResourceString("Organization_Title"); } }

		public static string Organization_WebSite { get { return GetResourceString("Organization_WebSite"); } }

		public static string Role_Description { get { return GetResourceString("Role_Description"); } }

		public static string Role_Help { get { return GetResourceString("Role_Help"); } }

		public static string Role_Title { get { return GetResourceString("Role_Title"); } }

		public static string Technical_Contact { get { return GetResourceString("Technical_Contact"); } }

		public static string User { get { return GetResourceString("User"); } }

		public static string VerifyUser_BrowserRemembered { get { return GetResourceString("VerifyUser_BrowserRemembered"); } }

		public static string VerifyUser_EmailConfirmed { get { return GetResourceString("VerifyUser_EmailConfirmed"); } }

		public static string VerifyUser_ExistingPhoneNumber { get { return GetResourceString("VerifyUser_ExistingPhoneNumber"); } }

		public static string VerifyUser_PhoneConfirmed { get { return GetResourceString("VerifyUser_PhoneConfirmed"); } }

		public static string AcceptInviteVM_Description { get { return GetResourceString("AcceptInviteVM_Description"); } }

		public static string AcceptInviteVM_Help { get { return GetResourceString("AcceptInviteVM_Help"); } }

		public static string AcceptInviteVM_Title { get { return GetResourceString("AcceptInviteVM_Title"); } }

		public static string ChangePasswordVM_Description { get { return GetResourceString("ChangePasswordVM_Description"); } }

		public static string ChangePasswordVM_Help { get { return GetResourceString("ChangePasswordVM_Help"); } }

		public static string ChangePasswordVM_Title { get { return GetResourceString("ChangePasswordVM_Title"); } }

		public static string CreateLocationVM_Description { get { return GetResourceString("CreateLocationVM_Description"); } }

		public static string CreateLocationVM_Help { get { return GetResourceString("CreateLocationVM_Help"); } }

		public static string CreateLocationVM_Title { get { return GetResourceString("CreateLocationVM_Title"); } }

		public static string CreateOrganizationVM_Description { get { return GetResourceString("CreateOrganizationVM_Description"); } }

		public static string CreateOrganizationVM_Help { get { return GetResourceString("CreateOrganizationVM_Help"); } }

		public static string CreateOrganizationVM_Title { get { return GetResourceString("CreateOrganizationVM_Title"); } }

		public static string ExternalLoginConfirmVM_Title { get { return GetResourceString("ExternalLoginConfirmVM_Title"); } }

		public static string ExternalLoginConfirmVM_Description { get { return GetResourceString("ExternalLoginConfirmVM_Description"); } }

		public static string ExternalLoginConfirmVM_Help { get { return GetResourceString("ExternalLoginConfirmVM_Help"); } }

		public static string ForgotPasswordVM_Description { get { return GetResourceString("ForgotPasswordVM_Description"); } }

		public static string ForgotPasswordVM_Help { get { return GetResourceString("ForgotPasswordVM_Help"); } }

		public static string ForgotPasswordVM_Title { get { return GetResourceString("ForgotPasswordVM_Title"); } }

		public static string IndexVM_Description { get { return GetResourceString("IndexVM_Description"); } }

		public static string IndexVM_Help { get { return GetResourceString("IndexVM_Help"); } }

		public static string IndexVM_Title { get { return GetResourceString("IndexVM_Title"); } }

		public static string InviteUserVM_Description { get { return GetResourceString("InviteUserVM_Description"); } }

		public static string InviteUserVM_Help { get { return GetResourceString("InviteUserVM_Help"); } }

		public static string InviteUserVM_Title { get { return GetResourceString("InviteUserVM_Title"); } }

		public static string LocationVM_Description { get { return GetResourceString("LocationVM_Description"); } }

		public static string LocationVM_Help { get { return GetResourceString("LocationVM_Help"); } }

		public static string LocationVM_Title { get { return GetResourceString("LocationVM_Title"); } }

		public static string LoginVM_Description { get { return GetResourceString("LoginVM_Description"); } }

		public static string LoginVM_Help { get { return GetResourceString("LoginVM_Help"); } }

		public static string LoginVM_Title { get { return GetResourceString("LoginVM_Title"); } }

		public static string OrganizationDetailsVM_Description { get { return GetResourceString("OrganizationDetailsVM_Description"); } }

		public static string OrganizationDetailVM_Help { get { return GetResourceString("OrganizationDetailVM_Help"); } }

		public static string OrganizationDetailVM_Title { get { return GetResourceString("OrganizationDetailVM_Title"); } }

		public static string OrganizationVM_Description { get { return GetResourceString("OrganizationVM_Description"); } }

		public static string OrganizationVM_Help { get { return GetResourceString("OrganizationVM_Help"); } }

		public static string OrganizationVM_Title { get { return GetResourceString("OrganizationVM_Title"); } }

		public static string RegisterVM_Description { get { return GetResourceString("RegisterVM_Description"); } }

		public static string RegisterVM_Help { get { return GetResourceString("RegisterVM_Help"); } }

		public static string RegisterVM_Title { get { return GetResourceString("RegisterVM_Title"); } }

		public static string ResetPassword_Description { get { return GetResourceString("ResetPassword_Description"); } }

		public static string ResetPassword_Help { get { return GetResourceString("ResetPassword_Help"); } }

		public static string ResetPassword_Title { get { return GetResourceString("ResetPassword_Title"); } }

		public static string SendCodeVM_Description { get { return GetResourceString("SendCodeVM_Description"); } }

		public static string SendCodeVM_Help { get { return GetResourceString("SendCodeVM_Help"); } }

		public static string SendCodeVM_Title { get { return GetResourceString("SendCodeVM_Title"); } }

		public static string SetPasswordVM_Description { get { return GetResourceString("SetPasswordVM_Description"); } }

		public static string SetPasswordVM_Help { get { return GetResourceString("SetPasswordVM_Help"); } }

		public static string SetPasswordVM_Title { get { return GetResourceString("SetPasswordVM_Title"); } }

		public static string UpdateLocationVM_Help { get { return GetResourceString("UpdateLocationVM_Help"); } }

		public static string UpdateLocationVM_Title { get { return GetResourceString("UpdateLocationVM_Title"); } }

		public static string UpdateLocatoinVM_Description { get { return GetResourceString("UpdateLocatoinVM_Description"); } }

		public static string UpdateOrganizationVM_Description { get { return GetResourceString("UpdateOrganizationVM_Description"); } }

		public static string UpdateOrganizationVM_Help { get { return GetResourceString("UpdateOrganizationVM_Help"); } }

		public static string UpdateOrganizationVM_Title { get { return GetResourceString("UpdateOrganizationVM_Title"); } }

		public static string VerifyCodeVM_Description { get { return GetResourceString("VerifyCodeVM_Description"); } }

		public static string VerifyCodeVM_Help { get { return GetResourceString("VerifyCodeVM_Help"); } }

		public static string VerifyCodeVM_Title { get { return GetResourceString("VerifyCodeVM_Title"); } }

		public static string VerifyPhoneNumberVM_Description { get { return GetResourceString("VerifyPhoneNumberVM_Description"); } }

		public static string VerifyPhoneNumberVM_Help { get { return GetResourceString("VerifyPhoneNumberVM_Help"); } }

		public static string VerifyPhoneNumberVM_Title { get { return GetResourceString("VerifyPhoneNumberVM_Title"); } }

		public static string AppUser_IsSystemAdmin { get { return GetResourceString("AppUser_IsSystemAdmin"); } }

		public static string Common_Key { get { return GetResourceString("Common_Key"); } }

		public static string Common_Key_Help { get { return GetResourceString("Common_Key_Help"); } }

		public static string Common_Key_Validation { get { return GetResourceString("Common_Key_Validation"); } }

		public static string Subscription_Description { get { return GetResourceString("Subscription_Description"); } }

		public static string Subscription_Help { get { return GetResourceString("Subscription_Help"); } }

		public static string Subscription_Title { get { return GetResourceString("Subscription_Title"); } }

		public static string Common_Name { get { return GetResourceString("Common_Name"); } }

		public static string AssetSet_Description { get { return GetResourceString("AssetSet_Description"); } }

		public static string AssetSet_Help { get { return GetResourceString("AssetSet_Help"); } }

		public static string AssetSet_IsRestricted { get { return GetResourceString("AssetSet_IsRestricted"); } }

		public static string AssetSet_IsRestricted_Help { get { return GetResourceString("AssetSet_IsRestricted_Help"); } }

		public static string AssetSet_Title { get { return GetResourceString("AssetSet_Title"); } }

		public static string Team_Description { get { return GetResourceString("Team_Description"); } }

		public static string Team_Help { get { return GetResourceString("Team_Help"); } }

		public static string Team_Title { get { return GetResourceString("Team_Title"); } }

		public static string AuthErr_InvalidCredentials { get { return GetResourceString("AuthErr_InvalidCredentials"); } }

		public static string AuthErr_InvalidRefreshToken { get { return GetResourceString("AuthErr_InvalidRefreshToken"); } }

		public static string AuthErr_RefreshTokenExpired { get { return GetResourceString("AuthErr_RefreshTokenExpired"); } }

		public static string AuthErr_InvalidGrantType { get { return GetResourceString("AuthErr_InvalidGrantType"); } }

		public static string AuthErr_CouldNotFindUserAccount { get { return GetResourceString("AuthErr_CouldNotFindUserAccount"); } }

		public static string AuthErr_MissingAppId { get { return GetResourceString("AuthErr_MissingAppId"); } }

		public static string AuthErr_MissingClientType { get { return GetResourceString("AuthErr_MissingClientType"); } }

		public static string AuthErr_MissingAppInstanceid { get { return GetResourceString("AuthErr_MissingAppInstanceid"); } }

		public static string AuthErr_EmailInvalidFormat { get { return GetResourceString("AuthErr_EmailInvalidFormat"); } }

		public static string AuthErr_MissingEmailAddress { get { return GetResourceString("AuthErr_MissingEmailAddress"); } }

		public static string AuthErr_MissingPassword { get { return GetResourceString("AuthErr_MissingPassword"); } }

		public static string AuthErr_MissingRefreshToken { get { return GetResourceString("AuthErr_MissingRefreshToken"); } }

		public static string AuthErr_RefreshToken_InvalidFormat { get { return GetResourceString("AuthErr_RefreshToken_InvalidFormat"); } }

		public static string AuthErr_RefreshToken_NotFound { get { return GetResourceString("AuthErr_RefreshToken_NotFound"); } }

		public static string AuthErr_RefreshTokenNotInStoraage { get { return GetResourceString("AuthErr_RefreshTokenNotInStoraage"); } }

		public static string AuthErr_UserIsNullForRefresh { get { return GetResourceString("AuthErr_UserIsNullForRefresh"); } }

		public static string AuthErr_AuthRequestNull { get { return GetResourceString("AuthErr_AuthRequestNull"); } }

		public static string AuthErr_MissingDeviceId { get { return GetResourceString("AuthErr_MissingDeviceId"); } }

		public static string RegErr_ErrorSendingEmail { get { return GetResourceString("RegErr_ErrorSendingEmail"); } }

		public static string RegErr_ErrorSendingPhoneNumber { get { return GetResourceString("RegErr_ErrorSendingPhoneNumber"); } }

		public static string RegErr_InvalidEmailAddress { get { return GetResourceString("RegErr_InvalidEmailAddress"); } }

		public static string RegErr_MissingFirstName { get { return GetResourceString("RegErr_MissingFirstName"); } }

		public static string RegErr_MissingLastName { get { return GetResourceString("RegErr_MissingLastName"); } }

		public static string RegErr_MissingPhoneNumber { get { return GetResourceString("RegErr_MissingPhoneNumber"); } }

		public static string AuthErr_OrgNotAuthorized { get { return GetResourceString("AuthErr_OrgNotAuthorized"); } }

		public static string AuthErr_ErrorUpdatingUser { get { return GetResourceString("AuthErr_ErrorUpdatingUser"); } }

		public static string AuthErr_UserLockedOut { get { return GetResourceString("AuthErr_UserLockedOut"); } }

		public static string Email_ResetPassword_Body { get { return GetResourceString("Email_ResetPassword_Body"); } }

		public static string Email_ResetPassword_Subject { get { return GetResourceString("Email_ResetPassword_Subject"); } }

		public static string Email_RestPassword_ErrorSending { get { return GetResourceString("Email_RestPassword_ErrorSending"); } }

		public static string Email_Verification_Body { get { return GetResourceString("Email_Verification_Body"); } }

		public static string Email_Verification_Subject { get { return GetResourceString("Email_Verification_Subject"); } }

		public static string Err_PwdChange_CouldNotFindUser { get { return GetResourceString("Err_PwdChange_CouldNotFindUser"); } }

		public static string Err_PwdChange_NewPassword_Missing { get { return GetResourceString("Err_PwdChange_NewPassword_Missing"); } }

		public static string Err_PwdChange_OldPassword_Missing { get { return GetResourceString("Err_PwdChange_OldPassword_Missing"); } }

		public static string Err_PwdChange_UserId_Missing { get { return GetResourceString("Err_PwdChange_UserId_Missing"); } }

		public static string Err_ResetPwd_CouldNotFindUser { get { return GetResourceString("Err_ResetPwd_CouldNotFindUser"); } }

		public static string Err_UserId_DoesNotMatch { get { return GetResourceString("Err_UserId_DoesNotMatch"); } }

		public static string SMS_CouldNotVerify { get { return GetResourceString("SMS_CouldNotVerify"); } }

		public static string SMS_Verification_Body { get { return GetResourceString("SMS_Verification_Body"); } }

		public static string Err_PwdChange_MissingUserId { get { return GetResourceString("Err_PwdChange_MissingUserId"); } }

		public static string Err_PwdChange_UserIdMismatch { get { return GetResourceString("Err_PwdChange_UserIdMismatch"); } }

		public static string Err_PwdReset_MissingNewPassword { get { return GetResourceString("Err_PwdReset_MissingNewPassword"); } }

		public static string Err_PwdReset_MissingToken { get { return GetResourceString("Err_PwdReset_MissingToken"); } }

		public static string Err_PwdReset_MssingEmail { get { return GetResourceString("Err_PwdReset_MssingEmail"); } }

		public static string ErrInvitation_AlreayAccepted { get { return GetResourceString("ErrInvitation_AlreayAccepted"); } }

		public static string ErrInvitation_CantFind { get { return GetResourceString("ErrInvitation_CantFind"); } }

		public static string AuthError_NotSysAdmin { get { return GetResourceString("AuthError_NotSysAdmin"); } }

		public static string AppUser_IsOrgAdmin { get { return GetResourceString("AppUser_IsOrgAdmin"); } }

		public static string AuthErr_NotOrgAdmin { get { return GetResourceString("AuthErr_NotOrgAdmin"); } }

		public static string AuthErr_CanNotRemoveSelfFromOrgAdmin { get { return GetResourceString("AuthErr_CanNotRemoveSelfFromOrgAdmin"); } }

		public static string AuthErr_CouldNotFindUser { get { return GetResourceString("AuthErr_CouldNotFindUser"); } }

		public static string AuthErr_CurrentOrgAlreadySet { get { return GetResourceString("AuthErr_CurrentOrgAlreadySet"); } }

		public static string Err_PwdChange_Token_Missing { get { return GetResourceString("Err_PwdChange_Token_Missing"); } }

		public static string RegErr_MissingPassword { get { return GetResourceString("RegErr_MissingPassword"); } }

		public static string RegErr_UserAlreadyExists { get { return GetResourceString("RegErr_UserAlreadyExists"); } }

		public static string AuthErr_InviteNotActive { get { return GetResourceString("AuthErr_InviteNotActive"); } }

		public static string InviteErr_EmailInvalid { get { return GetResourceString("InviteErr_EmailInvalid"); } }

		public static string InviteErr_EmailIsEmpty { get { return GetResourceString("InviteErr_EmailIsEmpty"); } }

		public static string InviteErr_InviteIsNull { get { return GetResourceString("InviteErr_InviteIsNull"); } }

		public static string InviteErr_NameIsRequired { get { return GetResourceString("InviteErr_NameIsRequired"); } }

		public static string ClientApp_AppAuthKey1 { get { return GetResourceString("ClientApp_AppAuthKey1"); } }

		public static string ClientApp_AppAuthKey2 { get { return GetResourceString("ClientApp_AppAuthKey2"); } }

		public static string ClientApp_Description { get { return GetResourceString("ClientApp_Description"); } }

		public static string ClientApp_DeviceConfigs { get { return GetResourceString("ClientApp_DeviceConfigs"); } }

		public static string ClientApp_DeviceTypes { get { return GetResourceString("ClientApp_DeviceTypes"); } }

		public static string ClientApp_Help { get { return GetResourceString("ClientApp_Help"); } }

		public static string ClientApp_Instance { get { return GetResourceString("ClientApp_Instance"); } }

		public static string ClientApp_SelectInstance { get { return GetResourceString("ClientApp_SelectInstance"); } }

		public static string ClientApp_Title { get { return GetResourceString("ClientApp_Title"); } }

		public static string Common_IsPublic { get { return GetResourceString("Common_IsPublic"); } }

		public static string AppUser_IsAppBuilder { get { return GetResourceString("AppUser_IsAppBuilder"); } }

		public static string Appuser_IsRuntimeUser { get { return GetResourceString("Appuser_IsRuntimeUser"); } }

		public static string AppUser_IsUserDevice { get { return GetResourceString("AppUser_IsUserDevice"); } }

		public static string Appuser_IsAccountDisabled { get { return GetResourceString("Appuser_IsAccountDisabled"); } }

		public static string RegisterUserExists_3rdParty { get { return GetResourceString("RegisterUserExists_3rdParty"); } }

		public static string Organization_CreateGettingStartedData { get { return GetResourceString("Organization_CreateGettingStartedData"); } }

		public static string Organization_CreateGettingStartedData_Help { get { return GetResourceString("Organization_CreateGettingStartedData_Help"); } }

		public static string DistroList_Description { get { return GetResourceString("DistroList_Description"); } }

		public static string DistroList_Help { get { return GetResourceString("DistroList_Help"); } }

		public static string DistroList_Name { get { return GetResourceString("DistroList_Name"); } }

		public static string DownTimeType_Admin { get { return GetResourceString("DownTimeType_Admin"); } }

		public static string DownTimeType_Holiday { get { return GetResourceString("DownTimeType_Holiday"); } }

		public static string DownTimeType_Other { get { return GetResourceString("DownTimeType_Other"); } }

		public static string DownTimeType_ScheduledMaintenance { get { return GetResourceString("DownTimeType_ScheduledMaintenance"); } }

		public static string DownTimeType_Select { get { return GetResourceString("DownTimeType_Select"); } }

		public static string HolidaySet_Culture_Or_Country { get { return GetResourceString("HolidaySet_Culture_Or_Country"); } }

		public static string HolidaySet_Description { get { return GetResourceString("HolidaySet_Description"); } }

		public static string HolidaySet_Help { get { return GetResourceString("HolidaySet_Help"); } }

		public static string HolidaySet_Holidays { get { return GetResourceString("HolidaySet_Holidays"); } }

		public static string HolidaySet_Title { get { return GetResourceString("HolidaySet_Title"); } }

		public static string ScheduledDowntimePeriod_Description { get { return GetResourceString("ScheduledDowntimePeriod_Description"); } }

		public static string ScheduledDowntimePeriod_End { get { return GetResourceString("ScheduledDowntimePeriod_End"); } }

		public static string ScheduledDowntimePeriod_End_Help { get { return GetResourceString("ScheduledDowntimePeriod_End_Help"); } }

		public static string ScheduledDowntimePeriod_Help { get { return GetResourceString("ScheduledDowntimePeriod_Help"); } }

		public static string ScheduledDowntimePeriod_Start { get { return GetResourceString("ScheduledDowntimePeriod_Start"); } }

		public static string ScheduledDowntimePeriod_Start_Help { get { return GetResourceString("ScheduledDowntimePeriod_Start_Help"); } }

		public static string ScheduledDowntimePeriod_TItle { get { return GetResourceString("ScheduledDowntimePeriod_TItle"); } }

		public static string ScheduledDowntime_AllDay { get { return GetResourceString("ScheduledDowntime_AllDay"); } }

		public static string ScheduledDowntime_Day { get { return GetResourceString("ScheduledDowntime_Day"); } }

		public static string ScheduledDowntime_DayOfWeek { get { return GetResourceString("ScheduledDowntime_DayOfWeek"); } }

		public static string ScheduledDowntime_Description { get { return GetResourceString("ScheduledDowntime_Description"); } }

		public static string ScheduledDowntime_DowntimeType { get { return GetResourceString("ScheduledDowntime_DowntimeType"); } }

		public static string ScheduledDowntime_Help { get { return GetResourceString("ScheduledDowntime_Help"); } }

		public static string ScheduledDowntime_Month { get { return GetResourceString("ScheduledDowntime_Month"); } }

		public static string ScheduledDowntime_Periods { get { return GetResourceString("ScheduledDowntime_Periods"); } }

		public static string ScheduledDowntime_ScheduleType { get { return GetResourceString("ScheduledDowntime_ScheduleType"); } }

		public static string ScheduledDowntime_ScheduleType_Select { get { return GetResourceString("ScheduledDowntime_ScheduleType_Select"); } }

		public static string ScheduledDowntime_ScheduleType_SpecificDate { get { return GetResourceString("ScheduledDowntime_ScheduleType_SpecificDate"); } }

		public static string ScheduledDowntime_ScheduleType_DayInMonth { get { return GetResourceString("ScheduledDowntime_ScheduleType_DayInMonth"); } }

		public static string ScheduledDowntime_ScheduleType_DayOfWeekOfWeekInMonth { get { return GetResourceString("ScheduledDowntime_ScheduleType_DayOfWeekOfWeekInMonth"); } }

		public static string ScheduledDowntime_Title { get { return GetResourceString("ScheduledDowntime_Title"); } }

		public static string ScheduledDowntime_Type { get { return GetResourceString("ScheduledDowntime_Type"); } }

		public static string ScheduledDowntime_Year { get { return GetResourceString("ScheduledDowntime_Year"); } }

		public static string ScheudledDowntime_Week { get { return GetResourceString("ScheudledDowntime_Week"); } }

		public static string DayOfWeek_Friday { get { return GetResourceString("DayOfWeek_Friday"); } }

		public static string DayOfWeek_Monday { get { return GetResourceString("DayOfWeek_Monday"); } }

		public static string DayOfWeek_Saturday { get { return GetResourceString("DayOfWeek_Saturday"); } }

		public static string DayOfWeek_Select { get { return GetResourceString("DayOfWeek_Select"); } }

		public static string DayOfWeek_Sunday { get { return GetResourceString("DayOfWeek_Sunday"); } }

		public static string DayOfWeek_Thursday { get { return GetResourceString("DayOfWeek_Thursday"); } }

		public static string DayOfWeek_Tuesday { get { return GetResourceString("DayOfWeek_Tuesday"); } }

		public static string DayOfWeek_Wednesday { get { return GetResourceString("DayOfWeek_Wednesday"); } }

		public static string Month_April { get { return GetResourceString("Month_April"); } }

		public static string Month_August { get { return GetResourceString("Month_August"); } }

		public static string Month_December { get { return GetResourceString("Month_December"); } }

		public static string Month_February { get { return GetResourceString("Month_February"); } }

		public static string Month_January { get { return GetResourceString("Month_January"); } }

		public static string Month_July { get { return GetResourceString("Month_July"); } }

		public static string Month_June { get { return GetResourceString("Month_June"); } }

		public static string Month_March { get { return GetResourceString("Month_March"); } }

		public static string Month_May { get { return GetResourceString("Month_May"); } }

		public static string Month_November { get { return GetResourceString("Month_November"); } }

		public static string Month_October { get { return GetResourceString("Month_October"); } }

		public static string Month_Select { get { return GetResourceString("Month_Select"); } }

		public static string Month_September { get { return GetResourceString("Month_September"); } }

		public static string ScheduledDowntime_ScheduleType_DayOfWeek { get { return GetResourceString("ScheduledDowntime_ScheduleType_DayOfWeek"); } }

		public static string AppUser_TeamsAccountName { get { return GetResourceString("AppUser_TeamsAccountName"); } }

		public static string AppUser_Address1 { get { return GetResourceString("AppUser_Address1"); } }

		public static string AppUser_Address2 { get { return GetResourceString("AppUser_Address2"); } }

		public static string AppUser_Bio { get { return GetResourceString("AppUser_Bio"); } }

		public static string AppUser_City { get { return GetResourceString("AppUser_City"); } }

		public static string AppUser_Country { get { return GetResourceString("AppUser_Country"); } }

		public static string Common_PostalCode { get { return GetResourceString("Common_PostalCode"); } }

		public static string AppUser_StateProvince { get { return GetResourceString("AppUser_StateProvince"); } }

		public static string AppUser_UserTitle { get { return GetResourceString("AppUser_UserTitle"); } }

		public static string ModuleStatus_Alpha { get { return GetResourceString("ModuleStatus_Alpha"); } }

		public static string ModuleStatus_Beta { get { return GetResourceString("ModuleStatus_Beta"); } }

		public static string ModuleStatus_Development { get { return GetResourceString("ModuleStatus_Development"); } }

		public static string ModuleStatus_Live { get { return GetResourceString("ModuleStatus_Live"); } }

		public static string ModuleStatus_Preview { get { return GetResourceString("ModuleStatus_Preview"); } }

		public static string ModuleStatus_Retired { get { return GetResourceString("ModuleStatus_Retired"); } }

		public static string ModuleStatus_Select { get { return GetResourceString("ModuleStatus_Select"); } }

		public static string Module_CardIcon { get { return GetResourceString("Module_CardIcon"); } }

		public static string Module_CardSummary { get { return GetResourceString("Module_CardSummary"); } }

		public static string Module_CardTitle { get { return GetResourceString("Module_CardTitle"); } }

		public static string Area_Help { get { return GetResourceString("Area_Help"); } }

		public static string Area_Title { get { return GetResourceString("Area_Title"); } }

		public static string Feature_Help { get { return GetResourceString("Feature_Help"); } }

		public static string Feature_TItle { get { return GetResourceString("Feature_TItle"); } }

		public static string Module_Help { get { return GetResourceString("Module_Help"); } }

		public static string Module_Title { get { return GetResourceString("Module_Title"); } }

		public static string Page_Help { get { return GetResourceString("Page_Help"); } }

		public static string Page_Title { get { return GetResourceString("Page_Title"); } }

		public static string Module_RestrictByDefault { get { return GetResourceString("Module_RestrictByDefault"); } }

		public static string Module_RestrictByDefault_Help { get { return GetResourceString("Module_RestrictByDefault_Help"); } }

		public static string Module_IsExternalLink { get { return GetResourceString("Module_IsExternalLink"); } }

		public static string Module_IsLegacyNGX { get { return GetResourceString("Module_IsLegacyNGX"); } }

		public static string Module_Link { get { return GetResourceString("Module_Link"); } }

		public static string Module_OpenInNewTab { get { return GetResourceString("Module_OpenInNewTab"); } }

		public static string Role_IsSystemRole { get { return GetResourceString("Role_IsSystemRole"); } }

		public static string Feature_Icon { get { return GetResourceString("Feature_Icon"); } }

		public static string Feature_MenuTitle { get { return GetResourceString("Feature_MenuTitle"); } }

		public static string Feature_Summary { get { return GetResourceString("Feature_Summary"); } }

		public static string Menu_DoNotDisplay { get { return GetResourceString("Menu_DoNotDisplay"); } }

		public static string Menu_DoNotDisplay_Help { get { return GetResourceString("Menu_DoNotDisplay_Help"); } }

		public static string AuthSingleuseToken_TokenNotFound { get { return GetResourceString("AuthSingleuseToken_TokenNotFound"); } }

		public static string AuthSingleuseToken_UserNotFound { get { return GetResourceString("AuthSingleuseToken_UserNotFound"); } }

		public static string CalendarEventType_Holiday { get { return GetResourceString("CalendarEventType_Holiday"); } }

		public static string CalendarEventType_Networking { get { return GetResourceString("CalendarEventType_Networking"); } }

		public static string CalendarEventType_Other { get { return GetResourceString("CalendarEventType_Other"); } }

		public static string CalendarEventType_OutOfOffice { get { return GetResourceString("CalendarEventType_OutOfOffice"); } }

		public static string CalendarEventType_UserGroup { get { return GetResourceString("CalendarEventType_UserGroup"); } }

		public static string CalendarEvent_Title { get { return GetResourceString("CalendarEvent_Title"); } }

		public static string Calendar_AllDay { get { return GetResourceString("Calendar_AllDay"); } }

		public static string Calendar_Date { get { return GetResourceString("Calendar_Date"); } }

		public static string Calendar_Description { get { return GetResourceString("Calendar_Description"); } }

		public static string Calendar_End { get { return GetResourceString("Calendar_End"); } }

		public static string Calendar_EventLink { get { return GetResourceString("Calendar_EventLink"); } }

		public static string Calendar_EventType { get { return GetResourceString("Calendar_EventType"); } }

		public static string Calendar_EventType_Select { get { return GetResourceString("Calendar_EventType_Select"); } }

		public static string Calendar_ObjectDescription { get { return GetResourceString("Calendar_ObjectDescription"); } }

		public static string Calendar_ObjectTitle { get { return GetResourceString("Calendar_ObjectTitle"); } }

		public static string Calendar_Start { get { return GetResourceString("Calendar_Start"); } }

		public static string Organization_LandingPage { get { return GetResourceString("Organization_LandingPage"); } }

		public static string Organization_LandingPage_Help { get { return GetResourceString("Organization_LandingPage_Help"); } }

		public static string Organization_DefaultContributor { get { return GetResourceString("Organization_DefaultContributor"); } }

		public static string Organization_DefaultContributor_Help { get { return GetResourceString("Organization_DefaultContributor_Help"); } }

		public static string Organization_DefaultProjectAdminLead { get { return GetResourceString("Organization_DefaultProjectAdminLead"); } }

		public static string Organization_DefaultProjectAdminLead_Help { get { return GetResourceString("Organization_DefaultProjectAdminLead_Help"); } }

		public static string Organization_DefaultProjectLead { get { return GetResourceString("Organization_DefaultProjectLead"); } }

		public static string Organization_DefaultProjectLead_Help { get { return GetResourceString("Organization_DefaultProjectLead_Help"); } }

		public static string Organization_DefaultQAResource { get { return GetResourceString("Organization_DefaultQAResource"); } }

		public static string Organization_DefaultQAResource_Help { get { return GetResourceString("Organization_DefaultQAResource_Help"); } }

		public static string Organization_DefaultResource_Watermark { get { return GetResourceString("Organization_DefaultResource_Watermark"); } }

		public static string Organization_OrgStatuses_Active { get { return GetResourceString("Organization_OrgStatuses_Active"); } }

		public static string Organization_OrgStatuses_Deactivated { get { return GetResourceString("Organization_OrgStatuses_Deactivated"); } }

		public static string Organization_OrgStatuses_Spam { get { return GetResourceString("Organization_OrgStatuses_Spam"); } }

		public static string Organization_Owner { get { return GetResourceString("Organization_Owner"); } }

		public static string Common_DesktopSupport { get { return GetResourceString("Common_DesktopSupport"); } }

		public static string Common_PhoneSupport { get { return GetResourceString("Common_PhoneSupport"); } }

		public static string Common_TabletSupport { get { return GetResourceString("Common_TabletSupport"); } }

		public static string HelpResource_Description { get { return GetResourceString("HelpResource_Description"); } }

		public static string HelpResource_DisplayInline { get { return GetResourceString("HelpResource_DisplayInline"); } }

		public static string HelpResource_Guide { get { return GetResourceString("HelpResource_Guide"); } }

		public static string HelpResource_Link { get { return GetResourceString("HelpResource_Link"); } }

		public static string HelpResource_SelectGuide { get { return GetResourceString("HelpResource_SelectGuide"); } }

		public static string HelpResource_Summary { get { return GetResourceString("HelpResource_Summary"); } }

		public static string HelpResource_Title { get { return GetResourceString("HelpResource_Title"); } }

		public static string Module_HelpResources { get { return GetResourceString("Module_HelpResources"); } }

		public static string Area_PageCategories { get { return GetResourceString("Area_PageCategories"); } }

		public static string Common_Category { get { return GetResourceString("Common_Category"); } }

		public static string Common_Category_Select { get { return GetResourceString("Common_Category_Select"); } }

		public static string ModuleCategory_Support { get { return GetResourceString("ModuleCategory_Support"); } }

		public static string ModuleCategory_Support_Summary { get { return GetResourceString("ModuleCategory_Support_Summary"); } }

		public static string ModuleCategory_Tools { get { return GetResourceString("ModuleCategory_Tools"); } }

		public static string ModuleCategory_Tools_Summary { get { return GetResourceString("ModuleCategory_Tools_Summary"); } }

		public static string ModuleCateogry_EndUser { get { return GetResourceString("ModuleCateogry_EndUser"); } }

		public static string ModuleCateogry_EndUser_Summary { get { return GetResourceString("ModuleCateogry_EndUser_Summary"); } }

		public static string ModuleCateogry_Other { get { return GetResourceString("ModuleCateogry_Other"); } }

		public static string Module_AreaCategories { get { return GetResourceString("Module_AreaCategories"); } }

		public static string UiCategory_Description { get { return GetResourceString("UiCategory_Description"); } }

		public static string UiCateogry_Title { get { return GetResourceString("UiCateogry_Title"); } }

		public static string Module_SortOrder { get { return GetResourceString("Module_SortOrder"); } }

		public static string UiCategory_Icon { get { return GetResourceString("UiCategory_Icon"); } }

		public static string UiCategory_Icon_Select { get { return GetResourceString("UiCategory_Icon_Select"); } }

		public static string Subscriptions_Title { get { return GetResourceString("Subscriptions_Title"); } }

		public static string Subscription_PaymentMethod { get { return GetResourceString("Subscription_PaymentMethod"); } }

		public static string Subscription_PaymentMethod_Date { get { return GetResourceString("Subscription_PaymentMethod_Date"); } }

		public static string Subscription_PaymentMethod_Expires { get { return GetResourceString("Subscription_PaymentMethod_Expires"); } }

		public static string Subscription_PaymentMethod_Help { get { return GetResourceString("Subscription_PaymentMethod_Help"); } }

		public static string Subscription_PaymentMethod_Status { get { return GetResourceString("Subscription_PaymentMethod_Status"); } }

		public static string Subscription_Status { get { return GetResourceString("Subscription_Status"); } }

		public static string ModuleCategory_Admin { get { return GetResourceString("ModuleCategory_Admin"); } }

		public static string ModuleCategory_Admin_Summary { get { return GetResourceString("ModuleCategory_Admin_Summary"); } }

		public static string ModuleCategory_IoT { get { return GetResourceString("ModuleCategory_IoT"); } }

		public static string ModuleCategory_IoT_Summary { get { return GetResourceString("ModuleCategory_IoT_Summary"); } }

		public static string Modules_Title { get { return GetResourceString("Modules_Title"); } }

		public static string AppUser_SSN { get { return GetResourceString("AppUser_SSN"); } }

		public static string AppUser_SSN_Help { get { return GetResourceString("AppUser_SSN_Help"); } }

		public static string Common_Icon { get { return GetResourceString("Common_Icon"); } }

		public static string Organization_Logo_Light { get { return GetResourceString("Organization_Logo_Light"); } }

		public static string Organization_TagLine { get { return GetResourceString("Organization_TagLine"); } }

		public static string Organization_DefaultTheme { get { return GetResourceString("Organization_DefaultTheme"); } }

		public static string HolidaySets_Title { get { return GetResourceString("HolidaySets_Title"); } }

		public static string DistroLists_Name { get { return GetResourceString("DistroLists_Name"); } }

		public static string ScheduledDowntimes_Title { get { return GetResourceString("ScheduledDowntimes_Title"); } }

		public static string ScheduledDowntime_DayOfWeek_Select { get { return GetResourceString("ScheduledDowntime_DayOfWeek_Select"); } }

		public static string DownTimeType_WorkWeek { get { return GetResourceString("DownTimeType_WorkWeek"); } }

		public static string ScheduledDowntimePeriod_EndOfDay { get { return GetResourceString("ScheduledDowntimePeriod_EndOfDay"); } }

		public static string ScheduledDowntimePeriod_StartOfDay { get { return GetResourceString("ScheduledDowntimePeriod_StartOfDay"); } }

		public static string ScheduledDowntimePeriod_EndOfDay_Help { get { return GetResourceString("ScheduledDowntimePeriod_EndOfDay_Help"); } }

		public static string ScheduledDowntimePeriod_InvalidTimeFormat { get { return GetResourceString("ScheduledDowntimePeriod_InvalidTimeFormat"); } }

		public static string ScheduledDowntimePeriod_StartOfDay_Help { get { return GetResourceString("ScheduledDowntimePeriod_StartOfDay_Help"); } }

		public static string ScheduleType_WeekDay { get { return GetResourceString("ScheduleType_WeekDay"); } }

		public static string ScheduleType_WeekEnd { get { return GetResourceString("ScheduleType_WeekEnd"); } }

		public static string AuthenticationLogs_Description { get { return GetResourceString("AuthenticationLogs_Description"); } }

		public static string AuthenticationLogs_Title { get { return GetResourceString("AuthenticationLogs_Title"); } }

		public static string AppUser_EmailSignature { get { return GetResourceString("AppUser_EmailSignature"); } }

		public static string Location_RoomNumber { get { return GetResourceString("Location_RoomNumber"); } }

		public static string Organization_DefaultInstance { get { return GetResourceString("Organization_DefaultInstance"); } }

		public static string Organization_DefaultInstance_Select { get { return GetResourceString("Organization_DefaultInstance_Select"); } }

		public static string Organization_DefaultRepo { get { return GetResourceString("Organization_DefaultRepo"); } }

		public static string Organization_DefaultRepo_Select { get { return GetResourceString("Organization_DefaultRepo_Select"); } }

		public static string Organization_Locations_Title { get { return GetResourceString("Organization_Locations_Title"); } }

		public static string OrgLocation_AdminContact_Select { get { return GetResourceString("OrgLocation_AdminContact_Select"); } }

		public static string OrgLocation_TechnicalContact_Select { get { return GetResourceString("OrgLocation_TechnicalContact_Select"); } }

		public static string DistributionList_ExternalContacts { get { return GetResourceString("DistributionList_ExternalContacts"); } }

		public static string ExternalContact_SendEmail { get { return GetResourceString("ExternalContact_SendEmail"); } }

		public static string ExternalContact_SendSMS { get { return GetResourceString("ExternalContact_SendSMS"); } }

		public static string LocationDiagrams_Description { get { return GetResourceString("LocationDiagrams_Description"); } }

		public static string LocationDiagrams_Title { get { return GetResourceString("LocationDiagrams_Title"); } }

		public static string LocationDiagram_BaseLocation { get { return GetResourceString("LocationDiagram_BaseLocation"); } }

		public static string LocationDiagram_BaseLocation_Help { get { return GetResourceString("LocationDiagram_BaseLocation_Help"); } }

		public static string LocationDiagram_Shape { get { return GetResourceString("LocationDiagram_Shape"); } }

		public static string LocationDiagram_Shape_Help { get { return GetResourceString("LocationDiagram_Shape_Help"); } }

		public static string LocationDiagram_Shape_OrgLocation { get { return GetResourceString("LocationDiagram_Shape_OrgLocation"); } }

		public static string LocationDiagram_Shape_OrgLocation_Help { get { return GetResourceString("LocationDiagram_Shape_OrgLocation_Help"); } }

		public static string LocationDiagram_Title { get { return GetResourceString("LocationDiagram_Title"); } }

		public static string Common_SelectDevice { get { return GetResourceString("Common_SelectDevice"); } }

		public static string Common_SelectLocation { get { return GetResourceString("Common_SelectLocation"); } }

		public static string LocationDiagram_Height { get { return GetResourceString("LocationDiagram_Height"); } }

		public static string LocationDiagram_Left { get { return GetResourceString("LocationDiagram_Left"); } }

		public static string LocationDiagram_Top { get { return GetResourceString("LocationDiagram_Top"); } }

		public static string LocationDiagram_Width { get { return GetResourceString("LocationDiagram_Width"); } }

		public static string ShapeType { get { return GetResourceString("ShapeType"); } }

		public static string ShapeType_Building { get { return GetResourceString("ShapeType_Building"); } }

		public static string ShapeType_Closet { get { return GetResourceString("ShapeType_Closet"); } }

		public static string ShapeType_Door { get { return GetResourceString("ShapeType_Door"); } }

		public static string ShapeType_ExternalEntrance { get { return GetResourceString("ShapeType_ExternalEntrance"); } }

		public static string ShapeType_ParkingLot { get { return GetResourceString("ShapeType_ParkingLot"); } }

		public static string ShapeType_Room { get { return GetResourceString("ShapeType_Room"); } }

		public static string ShapeType_Select { get { return GetResourceString("ShapeType_Select"); } }

		public static string ShapeType_Window { get { return GetResourceString("ShapeType_Window"); } }

		public static string ShapeType_Circle { get { return GetResourceString("ShapeType_Circle"); } }

		public static string Shape_Fill { get { return GetResourceString("Shape_Fill"); } }

		public static string Shape_FlipX { get { return GetResourceString("Shape_FlipX"); } }

		public static string Shape_FlipY { get { return GetResourceString("Shape_FlipY"); } }

		public static string Shape_Rotation { get { return GetResourceString("Shape_Rotation"); } }

		public static string Shape_Scale { get { return GetResourceString("Shape_Scale"); } }

		public static string Shape_Stroke { get { return GetResourceString("Shape_Stroke"); } }

		public static string LocationDiagramShapeGroup_Description { get { return GetResourceString("LocationDiagramShapeGroup_Description"); } }

		public static string LocationDiagramShapeGroup_Shapes { get { return GetResourceString("LocationDiagramShapeGroup_Shapes"); } }

		public static string LocationDiagramShapeGroup_Title { get { return GetResourceString("LocationDiagramShapeGroup_Title"); } }

		public static string LocationDiagram_Groups { get { return GetResourceString("LocationDiagram_Groups"); } }

		public static string LocationDiagram_Shapes { get { return GetResourceString("LocationDiagram_Shapes"); } }

		public static string LocationDiagramLayer_Description { get { return GetResourceString("LocationDiagramLayer_Description"); } }

		public static string LocationDiagramLayer_Shapes { get { return GetResourceString("LocationDiagramLayer_Shapes"); } }

		public static string LocationDiagramLayer_Title { get { return GetResourceString("LocationDiagramLayer_Title"); } }

		public static string LocationDiagramShapeGroup_Help { get { return GetResourceString("LocationDiagramShapeGroup_Help"); } }

		public static string LocationDiagram_Layers { get { return GetResourceString("LocationDiagram_Layers"); } }

		public static string LocationDiagramLayer_Groups { get { return GetResourceString("LocationDiagramLayer_Groups"); } }

		public static string LocationDiagramLayer_Locked { get { return GetResourceString("LocationDiagramLayer_Locked"); } }

		public static string LocationDiagramLayer_Visible { get { return GetResourceString("LocationDiagramLayer_Visible"); } }

		public static string ShapeType_Polygon { get { return GetResourceString("ShapeType_Polygon"); } }

		public static string Shape_Locked { get { return GetResourceString("Shape_Locked"); } }

		public static string Organizations_Title { get { return GetResourceString("Organizations_Title"); } }

		public static string OrgLocation_PhoneNumber { get { return GetResourceString("OrgLocation_PhoneNumber"); } }

		public static string Organization_IsForProductLine { get { return GetResourceString("Organization_IsForProductLine"); } }

		public static string Area_IsForProductLine { get { return GetResourceString("Area_IsForProductLine"); } }

		public static string Module_IsForProductLine { get { return GetResourceString("Module_IsForProductLine"); } }

		public static string Page_IsForProductLine { get { return GetResourceString("Page_IsForProductLine"); } }

		public static string Organization_AccentColor { get { return GetResourceString("Organization_AccentColor"); } }

		public static string Organization_Details { get { return GetResourceString("Organization_Details"); } }

		public static string Organization_HeroBackground { get { return GetResourceString("Organization_HeroBackground"); } }

		public static string Organization_HeroTitle { get { return GetResourceString("Organization_HeroTitle"); } }

		public static string Common_PrimaryBgColor { get { return GetResourceString("Common_PrimaryBgColor"); } }

		public static string Common_PrimaryTextColor { get { return GetResourceString("Common_PrimaryTextColor"); } }

		public static string Organization_SalesContact { get { return GetResourceString("Organization_SalesContact"); } }

		public static string Organization_SubLocation { get { return GetResourceString("Organization_SubLocation"); } }

		public static string Organization_SubLocations { get { return GetResourceString("Organization_SubLocations"); } }

		public static string Organization_SubLocation_Details { get { return GetResourceString("Organization_SubLocation_Details"); } }

		public static string DeviceOwnersDevices_Description { get { return GetResourceString("DeviceOwnersDevices_Description"); } }

		public static string DeviceOwnersDevices_Device { get { return GetResourceString("DeviceOwnersDevices_Device"); } }

		public static string DeviceOwnersDevices_DeviceId { get { return GetResourceString("DeviceOwnersDevices_DeviceId"); } }

		public static string DeviceOwnersDevices_DeviceRepository { get { return GetResourceString("DeviceOwnersDevices_DeviceRepository"); } }

		public static string DeviceOwnersDevices_Organization { get { return GetResourceString("DeviceOwnersDevices_Organization"); } }

		public static string DeviceOwnersDevices_Title { get { return GetResourceString("DeviceOwnersDevices_Title"); } }

		public static string DeviceOwners_Title { get { return GetResourceString("DeviceOwners_Title"); } }

		public static string DeviceOwner_Description { get { return GetResourceString("DeviceOwner_Description"); } }

		public static string DeviceOwner_Devices { get { return GetResourceString("DeviceOwner_Devices"); } }

		public static string DeviceOwner_EmailAddress { get { return GetResourceString("DeviceOwner_EmailAddress"); } }

		public static string DeviceOwner_FirstName { get { return GetResourceString("DeviceOwner_FirstName"); } }

		public static string DeviceOwner_LastName { get { return GetResourceString("DeviceOwner_LastName"); } }

		public static string DeviceOwner_Password { get { return GetResourceString("DeviceOwner_Password"); } }

		public static string DeviceOwner_Password_Confirm { get { return GetResourceString("DeviceOwner_Password_Confirm"); } }

		public static string DeviceOwner_PhoneNumber { get { return GetResourceString("DeviceOwner_PhoneNumber"); } }

		public static string DeviceOwner_Title { get { return GetResourceString("DeviceOwner_Title"); } }

		public static string ExternalContact_Description { get { return GetResourceString("ExternalContact_Description"); } }

		public static string ExternalContact_Title { get { return GetResourceString("ExternalContact_Title"); } }

		public static string Common_TimeZome { get { return GetResourceString("Common_TimeZome"); } }

		public static string Organization_Logo_DarkColor { get { return GetResourceString("Organization_Logo_DarkColor"); } }

		public static string Organization_Logo_DarkColor_Help { get { return GetResourceString("Organization_Logo_DarkColor_Help"); } }

		public static string Organization_Logo_LightColor_Help { get { return GetResourceString("Organization_Logo_LightColor_Help"); } }

		public static string DeviceOwnersDevices_Product { get { return GetResourceString("DeviceOwnersDevices_Product"); } }

		public static string Organization_BillingLocation { get { return GetResourceString("Organization_BillingLocation"); } }

		public static string Organization_BillingLocation_Select { get { return GetResourceString("Organization_BillingLocation_Select"); } }

		public static string OrgLocation_GeoBoundingBox { get { return GetResourceString("OrgLocation_GeoBoundingBox"); } }

		public static string OrgLocation_GeoBoundingBox_Help { get { return GetResourceString("OrgLocation_GeoBoundingBox_Help"); } }

		public static string Common_TextColor { get { return GetResourceString("Common_TextColor"); } }

		public static string Common_FillColor { get { return GetResourceString("Common_FillColor"); } }

		public static string Common_StrokeColor { get { return GetResourceString("Common_StrokeColor"); } }

		public static string Shape_TextRotation { get { return GetResourceString("Shape_TextRotation"); } }

		public static string OrgLocation_Diagram { get { return GetResourceString("OrgLocation_Diagram"); } }

		public static string OrgLocation_Diagram_Select { get { return GetResourceString("OrgLocation_Diagram_Select"); } }

		public static string OrgLocation_DeviceRepository { get { return GetResourceString("OrgLocation_DeviceRepository"); } }

		public static string OrgLocation_DeviceRepository_Select { get { return GetResourceString("OrgLocation_DeviceRepository_Select"); } }

		public static string AppUser_PrimaryOrganization { get { return GetResourceString("AppUser_PrimaryOrganization"); } }

		public static string AppUser_PrimaryOrganization_Help { get { return GetResourceString("AppUser_PrimaryOrganization_Help"); } }

		public static string Common_Customer { get { return GetResourceString("Common_Customer"); } }

		public static string LocationDiagram_Shape_CustomerLocation { get { return GetResourceString("LocationDiagram_Shape_CustomerLocation"); } }

		public static string LocationDiagram_Shape_CustomerLocation_Help { get { return GetResourceString("LocationDiagram_Shape_CustomerLocation_Help"); } }

		public static string DistroList_ParentList { get { return GetResourceString("DistroList_ParentList"); } }

		public static string DistroList_ParentList_Help { get { return GetResourceString("DistroList_ParentList_Help"); } }

		public static string Organization_DefaultDemoInstance { get { return GetResourceString("Organization_DefaultDemoInstance"); } }

		public static string Organization_DefaultDevelopmentInstance { get { return GetResourceString("Organization_DefaultDevelopmentInstance"); } }

		public static string Organization_DefaultTestInstance { get { return GetResourceString("Organization_DefaultTestInstance"); } }

		public static string OrgLocation_DistributionList { get { return GetResourceString("OrgLocation_DistributionList"); } }

		public static string OrgLocation_DistributionList_Select { get { return GetResourceString("OrgLocation_DistributionList_Select"); } }

		public static string OrgLocation_PrimaryDevice { get { return GetResourceString("OrgLocation_PrimaryDevice"); } }

		public static string OrgLocation_PrimaryDevice_Select { get { return GetResourceString("OrgLocation_PrimaryDevice_Select"); } }

		public static string Module_RootPath { get { return GetResourceString("Module_RootPath"); } }

		public static string Module_RootPath_Help { get { return GetResourceString("Module_RootPath_Help"); } }

		public static string ContactList_Title { get { return GetResourceString("ContactList_Title"); } }

		public static string ContactList_Description { get { return GetResourceString("ContactList_Description"); } }

			public static class Names
			{
				public const string Admin_Contact = "Admin_Contact";
				public const string AppUser_ConfirmPassword = "AppUser_ConfirmPassword";
				public const string AppUser_Description = "AppUser_Description";
				public const string AppUser_Email = "AppUser_Email";
				public const string AppUser_FirstName = "AppUser_FirstName";
				public const string AppUser_Help = "AppUser_Help";
				public const string AppUser_LastName = "AppUser_LastName";
				public const string AppUser_NewPassword = "AppUser_NewPassword";
				public const string AppUser_OldPassword = "AppUser_OldPassword";
				public const string AppUser_Password = "AppUser_Password";
				public const string AppUser_PasswordConfirmPasswordMatch = "AppUser_PasswordConfirmPasswordMatch";
				public const string AppUser_PhoneNumber = "AppUser_PhoneNumber";
				public const string AppUser_PhoneVerificationCode = "AppUser_PhoneVerificationCode";
				public const string AppUser_RememberMe = "AppUser_RememberMe";
				public const string AppUser_RememberMe_InThisBrowser = "AppUser_RememberMe_InThisBrowser";
				public const string AppUser_Title = "AppUser_Title";
				public const string Billing_Contact = "Billing_Contact";
				public const string Common_CreatedBy = "Common_CreatedBy";
				public const string Common_CreationDate = "Common_CreationDate";
				public const string Common_Description = "Common_Description";
				public const string Common_EmailAddress = "Common_EmailAddress";
				public const string Common_Id = "Common_Id";
				public const string Common_LastUpdatedBy = "Common_LastUpdatedBy";
				public const string Common_LastUpdatedDate = "Common_LastUpdatedDate";
				public const string Common_Namespace = "Common_Namespace";
				public const string Common_Notes = "Common_Notes";
				public const string Common_PhoneNumber = "Common_PhoneNumber";
				public const string Common_Role = "Common_Role";
				public const string Common_Status = "Common_Status";
				public const string GeoLocation_Description = "GeoLocation_Description";
				public const string GeoLocation_Help = "GeoLocation_Help";
				public const string GeoLocation_Title = "GeoLocation_Title";
				public const string ImageDetails_Description = "ImageDetails_Description";
				public const string ImageDetails_Help = "ImageDetails_Help";
				public const string ImageDetails_Title = "ImageDetails_Title";
				public const string InuteUser_Status_Declined = "InuteUser_Status_Declined";
				public const string Invitation_Description = "Invitation_Description";
				public const string Invitation_Help = "Invitation_Help";
				public const string Invitation_Title = "Invitation_Title";
				public const string InviteUser_AlreadyPartOfOrg = "InviteUser_AlreadyPartOfOrg";
				public const string InviteUser_ClickHere = "InviteUser_ClickHere";
				public const string InviteUser_Greeting_Label = "InviteUser_Greeting_Label";
				public const string InviteUser_Greeting_Message = "InviteUser_Greeting_Message";
				public const string InviteUser_InvitedById = "InviteUser_InvitedById";
				public const string InviteUser_InvitedByName = "InviteUser_InvitedByName";
				public const string InviteUser_Name = "InviteUser_Name";
				public const string InviteUser_Status = "InviteUser_Status";
				public const string InviteUser_Status_Accepted = "InviteUser_Status_Accepted";
				public const string InviteUser_Status_Queued = "InviteUser_Status_Queued";
				public const string Invite_Greeting_Subject = "Invite_Greeting_Subject";
				public const string LocationUserRole_Description = "LocationUserRole_Description";
				public const string LocationUserRole_Help = "LocationUserRole_Help";
				public const string LocationUserRole_Title = "LocationUserRole_Title";
				public const string LocationUser_Description = "LocationUser_Description";
				public const string LocationUser_Help = "LocationUser_Help";
				public const string LocationUser_Title = "LocationUser_Title";
				public const string LocationNamespace_Help = "LocationNamespace_Help";
				public const string Location_Address1 = "Location_Address1";
				public const string Location_Address2 = "Location_Address2";
				public const string Location_Admin_Contact = "Location_Admin_Contact";
				public const string Location_City = "Location_City";
				public const string Location_Country = "Location_Country";
				public const string Location_GeoLocation = "Location_GeoLocation";
				public const string Location_LocationName = "Location_LocationName";
				public const string Location_State = "Location_State";
				public const string Organization = "Organization";
				public const string OrganizationUserRole_Description = "OrganizationUserRole_Description";
				public const string OrganizationUserRole_Help = "OrganizationUserRole_Help";
				public const string OrganizationUserRole_Title = "OrganizationUserRole_Title";
				public const string OrganizationUser_CouldntAdd = "OrganizationUser_CouldntAdd";
				public const string OrganizationUser_UserExists = "OrganizationUser_UserExists";
				public const string OrganizationLocation_NamespaceInUse = "OrganizationLocation_NamespaceInUse";
				public const string OrganizationNamespace_Help = "OrganizationNamespace_Help";
				public const string Organization_User_Title = "Organization_User_Title";
				public const string Organization_User_Description = "Organization_User_Description";
				public const string Organization_User_Help = "Organization_User_Help";
				public const string Organization_CantCreate = "Organization_CantCreate";
				public const string Organization_Description = "Organization_Description";
				public const string Organization_Help = "Organization_Help";
				public const string Organization_Location = "Organization_Location";
				public const string Organization_Locations = "Organization_Locations";
				public const string Organization_Location_Description = "Organization_Location_Description";
				public const string Organization_Location_Help = "Organization_Location_Help";
				public const string Organization_Location_Title = "Organization_Location_Title";
				public const string Organization_Name = "Organization_Name";
				public const string Organization_NamespaceInUse = "Organization_NamespaceInUse";
				public const string Organization_Primary_Location = "Organization_Primary_Location";
				public const string Organization_Status_Active = "Organization_Status_Active";
				public const string Organization_Status_Active_BehindPayments = "Organization_Status_Active_BehindPayments";
				public const string Organization_Status_Archived = "Organization_Status_Archived";
				public const string Organization_Title = "Organization_Title";
				public const string Organization_WebSite = "Organization_WebSite";
				public const string Role_Description = "Role_Description";
				public const string Role_Help = "Role_Help";
				public const string Role_Title = "Role_Title";
				public const string Technical_Contact = "Technical_Contact";
				public const string User = "User";
				public const string VerifyUser_BrowserRemembered = "VerifyUser_BrowserRemembered";
				public const string VerifyUser_EmailConfirmed = "VerifyUser_EmailConfirmed";
				public const string VerifyUser_ExistingPhoneNumber = "VerifyUser_ExistingPhoneNumber";
				public const string VerifyUser_PhoneConfirmed = "VerifyUser_PhoneConfirmed";
				public const string AcceptInviteVM_Description = "AcceptInviteVM_Description";
				public const string AcceptInviteVM_Help = "AcceptInviteVM_Help";
				public const string AcceptInviteVM_Title = "AcceptInviteVM_Title";
				public const string ChangePasswordVM_Description = "ChangePasswordVM_Description";
				public const string ChangePasswordVM_Help = "ChangePasswordVM_Help";
				public const string ChangePasswordVM_Title = "ChangePasswordVM_Title";
				public const string CreateLocationVM_Description = "CreateLocationVM_Description";
				public const string CreateLocationVM_Help = "CreateLocationVM_Help";
				public const string CreateLocationVM_Title = "CreateLocationVM_Title";
				public const string CreateOrganizationVM_Description = "CreateOrganizationVM_Description";
				public const string CreateOrganizationVM_Help = "CreateOrganizationVM_Help";
				public const string CreateOrganizationVM_Title = "CreateOrganizationVM_Title";
				public const string ExternalLoginConfirmVM_Title = "ExternalLoginConfirmVM_Title";
				public const string ExternalLoginConfirmVM_Description = "ExternalLoginConfirmVM_Description";
				public const string ExternalLoginConfirmVM_Help = "ExternalLoginConfirmVM_Help";
				public const string ForgotPasswordVM_Description = "ForgotPasswordVM_Description";
				public const string ForgotPasswordVM_Help = "ForgotPasswordVM_Help";
				public const string ForgotPasswordVM_Title = "ForgotPasswordVM_Title";
				public const string IndexVM_Description = "IndexVM_Description";
				public const string IndexVM_Help = "IndexVM_Help";
				public const string IndexVM_Title = "IndexVM_Title";
				public const string InviteUserVM_Description = "InviteUserVM_Description";
				public const string InviteUserVM_Help = "InviteUserVM_Help";
				public const string InviteUserVM_Title = "InviteUserVM_Title";
				public const string LocationVM_Description = "LocationVM_Description";
				public const string LocationVM_Help = "LocationVM_Help";
				public const string LocationVM_Title = "LocationVM_Title";
				public const string LoginVM_Description = "LoginVM_Description";
				public const string LoginVM_Help = "LoginVM_Help";
				public const string LoginVM_Title = "LoginVM_Title";
				public const string OrganizationDetailsVM_Description = "OrganizationDetailsVM_Description";
				public const string OrganizationDetailVM_Help = "OrganizationDetailVM_Help";
				public const string OrganizationDetailVM_Title = "OrganizationDetailVM_Title";
				public const string OrganizationVM_Description = "OrganizationVM_Description";
				public const string OrganizationVM_Help = "OrganizationVM_Help";
				public const string OrganizationVM_Title = "OrganizationVM_Title";
				public const string RegisterVM_Description = "RegisterVM_Description";
				public const string RegisterVM_Help = "RegisterVM_Help";
				public const string RegisterVM_Title = "RegisterVM_Title";
				public const string ResetPassword_Description = "ResetPassword_Description";
				public const string ResetPassword_Help = "ResetPassword_Help";
				public const string ResetPassword_Title = "ResetPassword_Title";
				public const string SendCodeVM_Description = "SendCodeVM_Description";
				public const string SendCodeVM_Help = "SendCodeVM_Help";
				public const string SendCodeVM_Title = "SendCodeVM_Title";
				public const string SetPasswordVM_Description = "SetPasswordVM_Description";
				public const string SetPasswordVM_Help = "SetPasswordVM_Help";
				public const string SetPasswordVM_Title = "SetPasswordVM_Title";
				public const string UpdateLocationVM_Help = "UpdateLocationVM_Help";
				public const string UpdateLocationVM_Title = "UpdateLocationVM_Title";
				public const string UpdateLocatoinVM_Description = "UpdateLocatoinVM_Description";
				public const string UpdateOrganizationVM_Description = "UpdateOrganizationVM_Description";
				public const string UpdateOrganizationVM_Help = "UpdateOrganizationVM_Help";
				public const string UpdateOrganizationVM_Title = "UpdateOrganizationVM_Title";
				public const string VerifyCodeVM_Description = "VerifyCodeVM_Description";
				public const string VerifyCodeVM_Help = "VerifyCodeVM_Help";
				public const string VerifyCodeVM_Title = "VerifyCodeVM_Title";
				public const string VerifyPhoneNumberVM_Description = "VerifyPhoneNumberVM_Description";
				public const string VerifyPhoneNumberVM_Help = "VerifyPhoneNumberVM_Help";
				public const string VerifyPhoneNumberVM_Title = "VerifyPhoneNumberVM_Title";
				public const string AppUser_IsSystemAdmin = "AppUser_IsSystemAdmin";
				public const string Common_Key = "Common_Key";
				public const string Common_Key_Help = "Common_Key_Help";
				public const string Common_Key_Validation = "Common_Key_Validation";
				public const string Subscription_Description = "Subscription_Description";
				public const string Subscription_Help = "Subscription_Help";
				public const string Subscription_Title = "Subscription_Title";
				public const string Common_Name = "Common_Name";
				public const string AssetSet_Description = "AssetSet_Description";
				public const string AssetSet_Help = "AssetSet_Help";
				public const string AssetSet_IsRestricted = "AssetSet_IsRestricted";
				public const string AssetSet_IsRestricted_Help = "AssetSet_IsRestricted_Help";
				public const string AssetSet_Title = "AssetSet_Title";
				public const string Team_Description = "Team_Description";
				public const string Team_Help = "Team_Help";
				public const string Team_Title = "Team_Title";
				public const string AuthErr_InvalidCredentials = "AuthErr_InvalidCredentials";
				public const string AuthErr_InvalidRefreshToken = "AuthErr_InvalidRefreshToken";
				public const string AuthErr_RefreshTokenExpired = "AuthErr_RefreshTokenExpired";
				public const string AuthErr_InvalidGrantType = "AuthErr_InvalidGrantType";
				public const string AuthErr_CouldNotFindUserAccount = "AuthErr_CouldNotFindUserAccount";
				public const string AuthErr_MissingAppId = "AuthErr_MissingAppId";
				public const string AuthErr_MissingClientType = "AuthErr_MissingClientType";
				public const string AuthErr_MissingAppInstanceid = "AuthErr_MissingAppInstanceid";
				public const string AuthErr_EmailInvalidFormat = "AuthErr_EmailInvalidFormat";
				public const string AuthErr_MissingEmailAddress = "AuthErr_MissingEmailAddress";
				public const string AuthErr_MissingPassword = "AuthErr_MissingPassword";
				public const string AuthErr_MissingRefreshToken = "AuthErr_MissingRefreshToken";
				public const string AuthErr_RefreshToken_InvalidFormat = "AuthErr_RefreshToken_InvalidFormat";
				public const string AuthErr_RefreshToken_NotFound = "AuthErr_RefreshToken_NotFound";
				public const string AuthErr_RefreshTokenNotInStoraage = "AuthErr_RefreshTokenNotInStoraage";
				public const string AuthErr_UserIsNullForRefresh = "AuthErr_UserIsNullForRefresh";
				public const string AuthErr_AuthRequestNull = "AuthErr_AuthRequestNull";
				public const string AuthErr_MissingDeviceId = "AuthErr_MissingDeviceId";
				public const string RegErr_ErrorSendingEmail = "RegErr_ErrorSendingEmail";
				public const string RegErr_ErrorSendingPhoneNumber = "RegErr_ErrorSendingPhoneNumber";
				public const string RegErr_InvalidEmailAddress = "RegErr_InvalidEmailAddress";
				public const string RegErr_MissingFirstName = "RegErr_MissingFirstName";
				public const string RegErr_MissingLastName = "RegErr_MissingLastName";
				public const string RegErr_MissingPhoneNumber = "RegErr_MissingPhoneNumber";
				public const string AuthErr_OrgNotAuthorized = "AuthErr_OrgNotAuthorized";
				public const string AuthErr_ErrorUpdatingUser = "AuthErr_ErrorUpdatingUser";
				public const string AuthErr_UserLockedOut = "AuthErr_UserLockedOut";
				public const string Email_ResetPassword_Body = "Email_ResetPassword_Body";
				public const string Email_ResetPassword_Subject = "Email_ResetPassword_Subject";
				public const string Email_RestPassword_ErrorSending = "Email_RestPassword_ErrorSending";
				public const string Email_Verification_Body = "Email_Verification_Body";
				public const string Email_Verification_Subject = "Email_Verification_Subject";
				public const string Err_PwdChange_CouldNotFindUser = "Err_PwdChange_CouldNotFindUser";
				public const string Err_PwdChange_NewPassword_Missing = "Err_PwdChange_NewPassword_Missing";
				public const string Err_PwdChange_OldPassword_Missing = "Err_PwdChange_OldPassword_Missing";
				public const string Err_PwdChange_UserId_Missing = "Err_PwdChange_UserId_Missing";
				public const string Err_ResetPwd_CouldNotFindUser = "Err_ResetPwd_CouldNotFindUser";
				public const string Err_UserId_DoesNotMatch = "Err_UserId_DoesNotMatch";
				public const string SMS_CouldNotVerify = "SMS_CouldNotVerify";
				public const string SMS_Verification_Body = "SMS_Verification_Body";
				public const string Err_PwdChange_MissingUserId = "Err_PwdChange_MissingUserId";
				public const string Err_PwdChange_UserIdMismatch = "Err_PwdChange_UserIdMismatch";
				public const string Err_PwdReset_MissingNewPassword = "Err_PwdReset_MissingNewPassword";
				public const string Err_PwdReset_MissingToken = "Err_PwdReset_MissingToken";
				public const string Err_PwdReset_MssingEmail = "Err_PwdReset_MssingEmail";
				public const string ErrInvitation_AlreayAccepted = "ErrInvitation_AlreayAccepted";
				public const string ErrInvitation_CantFind = "ErrInvitation_CantFind";
				public const string AuthError_NotSysAdmin = "AuthError_NotSysAdmin";
				public const string AppUser_IsOrgAdmin = "AppUser_IsOrgAdmin";
				public const string AuthErr_NotOrgAdmin = "AuthErr_NotOrgAdmin";
				public const string AuthErr_CanNotRemoveSelfFromOrgAdmin = "AuthErr_CanNotRemoveSelfFromOrgAdmin";
				public const string AuthErr_CouldNotFindUser = "AuthErr_CouldNotFindUser";
				public const string AuthErr_CurrentOrgAlreadySet = "AuthErr_CurrentOrgAlreadySet";
				public const string Err_PwdChange_Token_Missing = "Err_PwdChange_Token_Missing";
				public const string RegErr_MissingPassword = "RegErr_MissingPassword";
				public const string RegErr_UserAlreadyExists = "RegErr_UserAlreadyExists";
				public const string AuthErr_InviteNotActive = "AuthErr_InviteNotActive";
				public const string InviteErr_EmailInvalid = "InviteErr_EmailInvalid";
				public const string InviteErr_EmailIsEmpty = "InviteErr_EmailIsEmpty";
				public const string InviteErr_InviteIsNull = "InviteErr_InviteIsNull";
				public const string InviteErr_NameIsRequired = "InviteErr_NameIsRequired";
				public const string ClientApp_AppAuthKey1 = "ClientApp_AppAuthKey1";
				public const string ClientApp_AppAuthKey2 = "ClientApp_AppAuthKey2";
				public const string ClientApp_Description = "ClientApp_Description";
				public const string ClientApp_DeviceConfigs = "ClientApp_DeviceConfigs";
				public const string ClientApp_DeviceTypes = "ClientApp_DeviceTypes";
				public const string ClientApp_Help = "ClientApp_Help";
				public const string ClientApp_Instance = "ClientApp_Instance";
				public const string ClientApp_SelectInstance = "ClientApp_SelectInstance";
				public const string ClientApp_Title = "ClientApp_Title";
				public const string Common_IsPublic = "Common_IsPublic";
				public const string AppUser_IsAppBuilder = "AppUser_IsAppBuilder";
				public const string Appuser_IsRuntimeUser = "Appuser_IsRuntimeUser";
				public const string AppUser_IsUserDevice = "AppUser_IsUserDevice";
				public const string Appuser_IsAccountDisabled = "Appuser_IsAccountDisabled";
				public const string RegisterUserExists_3rdParty = "RegisterUserExists_3rdParty";
				public const string Organization_CreateGettingStartedData = "Organization_CreateGettingStartedData";
				public const string Organization_CreateGettingStartedData_Help = "Organization_CreateGettingStartedData_Help";
				public const string DistroList_Description = "DistroList_Description";
				public const string DistroList_Help = "DistroList_Help";
				public const string DistroList_Name = "DistroList_Name";
				public const string DownTimeType_Admin = "DownTimeType_Admin";
				public const string DownTimeType_Holiday = "DownTimeType_Holiday";
				public const string DownTimeType_Other = "DownTimeType_Other";
				public const string DownTimeType_ScheduledMaintenance = "DownTimeType_ScheduledMaintenance";
				public const string DownTimeType_Select = "DownTimeType_Select";
				public const string HolidaySet_Culture_Or_Country = "HolidaySet_Culture_Or_Country";
				public const string HolidaySet_Description = "HolidaySet_Description";
				public const string HolidaySet_Help = "HolidaySet_Help";
				public const string HolidaySet_Holidays = "HolidaySet_Holidays";
				public const string HolidaySet_Title = "HolidaySet_Title";
				public const string ScheduledDowntimePeriod_Description = "ScheduledDowntimePeriod_Description";
				public const string ScheduledDowntimePeriod_End = "ScheduledDowntimePeriod_End";
				public const string ScheduledDowntimePeriod_End_Help = "ScheduledDowntimePeriod_End_Help";
				public const string ScheduledDowntimePeriod_Help = "ScheduledDowntimePeriod_Help";
				public const string ScheduledDowntimePeriod_Start = "ScheduledDowntimePeriod_Start";
				public const string ScheduledDowntimePeriod_Start_Help = "ScheduledDowntimePeriod_Start_Help";
				public const string ScheduledDowntimePeriod_TItle = "ScheduledDowntimePeriod_TItle";
				public const string ScheduledDowntime_AllDay = "ScheduledDowntime_AllDay";
				public const string ScheduledDowntime_Day = "ScheduledDowntime_Day";
				public const string ScheduledDowntime_DayOfWeek = "ScheduledDowntime_DayOfWeek";
				public const string ScheduledDowntime_Description = "ScheduledDowntime_Description";
				public const string ScheduledDowntime_DowntimeType = "ScheduledDowntime_DowntimeType";
				public const string ScheduledDowntime_Help = "ScheduledDowntime_Help";
				public const string ScheduledDowntime_Month = "ScheduledDowntime_Month";
				public const string ScheduledDowntime_Periods = "ScheduledDowntime_Periods";
				public const string ScheduledDowntime_ScheduleType = "ScheduledDowntime_ScheduleType";
				public const string ScheduledDowntime_ScheduleType_Select = "ScheduledDowntime_ScheduleType_Select";
				public const string ScheduledDowntime_ScheduleType_SpecificDate = "ScheduledDowntime_ScheduleType_SpecificDate";
				public const string ScheduledDowntime_ScheduleType_DayInMonth = "ScheduledDowntime_ScheduleType_DayInMonth";
				public const string ScheduledDowntime_ScheduleType_DayOfWeekOfWeekInMonth = "ScheduledDowntime_ScheduleType_DayOfWeekOfWeekInMonth";
				public const string ScheduledDowntime_Title = "ScheduledDowntime_Title";
				public const string ScheduledDowntime_Type = "ScheduledDowntime_Type";
				public const string ScheduledDowntime_Year = "ScheduledDowntime_Year";
				public const string ScheudledDowntime_Week = "ScheudledDowntime_Week";
				public const string DayOfWeek_Friday = "DayOfWeek_Friday";
				public const string DayOfWeek_Monday = "DayOfWeek_Monday";
				public const string DayOfWeek_Saturday = "DayOfWeek_Saturday";
				public const string DayOfWeek_Select = "DayOfWeek_Select";
				public const string DayOfWeek_Sunday = "DayOfWeek_Sunday";
				public const string DayOfWeek_Thursday = "DayOfWeek_Thursday";
				public const string DayOfWeek_Tuesday = "DayOfWeek_Tuesday";
				public const string DayOfWeek_Wednesday = "DayOfWeek_Wednesday";
				public const string Month_April = "Month_April";
				public const string Month_August = "Month_August";
				public const string Month_December = "Month_December";
				public const string Month_February = "Month_February";
				public const string Month_January = "Month_January";
				public const string Month_July = "Month_July";
				public const string Month_June = "Month_June";
				public const string Month_March = "Month_March";
				public const string Month_May = "Month_May";
				public const string Month_November = "Month_November";
				public const string Month_October = "Month_October";
				public const string Month_Select = "Month_Select";
				public const string Month_September = "Month_September";
				public const string ScheduledDowntime_ScheduleType_DayOfWeek = "ScheduledDowntime_ScheduleType_DayOfWeek";
				public const string AppUser_TeamsAccountName = "AppUser_TeamsAccountName";
				public const string AppUser_Address1 = "AppUser_Address1";
				public const string AppUser_Address2 = "AppUser_Address2";
				public const string AppUser_Bio = "AppUser_Bio";
				public const string AppUser_City = "AppUser_City";
				public const string AppUser_Country = "AppUser_Country";
				public const string Common_PostalCode = "Common_PostalCode";
				public const string AppUser_StateProvince = "AppUser_StateProvince";
				public const string AppUser_UserTitle = "AppUser_UserTitle";
				public const string ModuleStatus_Alpha = "ModuleStatus_Alpha";
				public const string ModuleStatus_Beta = "ModuleStatus_Beta";
				public const string ModuleStatus_Development = "ModuleStatus_Development";
				public const string ModuleStatus_Live = "ModuleStatus_Live";
				public const string ModuleStatus_Preview = "ModuleStatus_Preview";
				public const string ModuleStatus_Retired = "ModuleStatus_Retired";
				public const string ModuleStatus_Select = "ModuleStatus_Select";
				public const string Module_CardIcon = "Module_CardIcon";
				public const string Module_CardSummary = "Module_CardSummary";
				public const string Module_CardTitle = "Module_CardTitle";
				public const string Area_Help = "Area_Help";
				public const string Area_Title = "Area_Title";
				public const string Feature_Help = "Feature_Help";
				public const string Feature_TItle = "Feature_TItle";
				public const string Module_Help = "Module_Help";
				public const string Module_Title = "Module_Title";
				public const string Page_Help = "Page_Help";
				public const string Page_Title = "Page_Title";
				public const string Module_RestrictByDefault = "Module_RestrictByDefault";
				public const string Module_RestrictByDefault_Help = "Module_RestrictByDefault_Help";
				public const string Module_IsExternalLink = "Module_IsExternalLink";
				public const string Module_IsLegacyNGX = "Module_IsLegacyNGX";
				public const string Module_Link = "Module_Link";
				public const string Module_OpenInNewTab = "Module_OpenInNewTab";
				public const string Role_IsSystemRole = "Role_IsSystemRole";
				public const string Feature_Icon = "Feature_Icon";
				public const string Feature_MenuTitle = "Feature_MenuTitle";
				public const string Feature_Summary = "Feature_Summary";
				public const string Menu_DoNotDisplay = "Menu_DoNotDisplay";
				public const string Menu_DoNotDisplay_Help = "Menu_DoNotDisplay_Help";
				public const string AuthSingleuseToken_TokenNotFound = "AuthSingleuseToken_TokenNotFound";
				public const string AuthSingleuseToken_UserNotFound = "AuthSingleuseToken_UserNotFound";
				public const string CalendarEventType_Holiday = "CalendarEventType_Holiday";
				public const string CalendarEventType_Networking = "CalendarEventType_Networking";
				public const string CalendarEventType_Other = "CalendarEventType_Other";
				public const string CalendarEventType_OutOfOffice = "CalendarEventType_OutOfOffice";
				public const string CalendarEventType_UserGroup = "CalendarEventType_UserGroup";
				public const string CalendarEvent_Title = "CalendarEvent_Title";
				public const string Calendar_AllDay = "Calendar_AllDay";
				public const string Calendar_Date = "Calendar_Date";
				public const string Calendar_Description = "Calendar_Description";
				public const string Calendar_End = "Calendar_End";
				public const string Calendar_EventLink = "Calendar_EventLink";
				public const string Calendar_EventType = "Calendar_EventType";
				public const string Calendar_EventType_Select = "Calendar_EventType_Select";
				public const string Calendar_ObjectDescription = "Calendar_ObjectDescription";
				public const string Calendar_ObjectTitle = "Calendar_ObjectTitle";
				public const string Calendar_Start = "Calendar_Start";
				public const string Organization_LandingPage = "Organization_LandingPage";
				public const string Organization_LandingPage_Help = "Organization_LandingPage_Help";
				public const string Organization_DefaultContributor = "Organization_DefaultContributor";
				public const string Organization_DefaultContributor_Help = "Organization_DefaultContributor_Help";
				public const string Organization_DefaultProjectAdminLead = "Organization_DefaultProjectAdminLead";
				public const string Organization_DefaultProjectAdminLead_Help = "Organization_DefaultProjectAdminLead_Help";
				public const string Organization_DefaultProjectLead = "Organization_DefaultProjectLead";
				public const string Organization_DefaultProjectLead_Help = "Organization_DefaultProjectLead_Help";
				public const string Organization_DefaultQAResource = "Organization_DefaultQAResource";
				public const string Organization_DefaultQAResource_Help = "Organization_DefaultQAResource_Help";
				public const string Organization_DefaultResource_Watermark = "Organization_DefaultResource_Watermark";
				public const string Organization_OrgStatuses_Active = "Organization_OrgStatuses_Active";
				public const string Organization_OrgStatuses_Deactivated = "Organization_OrgStatuses_Deactivated";
				public const string Organization_OrgStatuses_Spam = "Organization_OrgStatuses_Spam";
				public const string Organization_Owner = "Organization_Owner";
				public const string Common_DesktopSupport = "Common_DesktopSupport";
				public const string Common_PhoneSupport = "Common_PhoneSupport";
				public const string Common_TabletSupport = "Common_TabletSupport";
				public const string HelpResource_Description = "HelpResource_Description";
				public const string HelpResource_DisplayInline = "HelpResource_DisplayInline";
				public const string HelpResource_Guide = "HelpResource_Guide";
				public const string HelpResource_Link = "HelpResource_Link";
				public const string HelpResource_SelectGuide = "HelpResource_SelectGuide";
				public const string HelpResource_Summary = "HelpResource_Summary";
				public const string HelpResource_Title = "HelpResource_Title";
				public const string Module_HelpResources = "Module_HelpResources";
				public const string Area_PageCategories = "Area_PageCategories";
				public const string Common_Category = "Common_Category";
				public const string Common_Category_Select = "Common_Category_Select";
				public const string ModuleCategory_Support = "ModuleCategory_Support";
				public const string ModuleCategory_Support_Summary = "ModuleCategory_Support_Summary";
				public const string ModuleCategory_Tools = "ModuleCategory_Tools";
				public const string ModuleCategory_Tools_Summary = "ModuleCategory_Tools_Summary";
				public const string ModuleCateogry_EndUser = "ModuleCateogry_EndUser";
				public const string ModuleCateogry_EndUser_Summary = "ModuleCateogry_EndUser_Summary";
				public const string ModuleCateogry_Other = "ModuleCateogry_Other";
				public const string Module_AreaCategories = "Module_AreaCategories";
				public const string UiCategory_Description = "UiCategory_Description";
				public const string UiCateogry_Title = "UiCateogry_Title";
				public const string Module_SortOrder = "Module_SortOrder";
				public const string UiCategory_Icon = "UiCategory_Icon";
				public const string UiCategory_Icon_Select = "UiCategory_Icon_Select";
				public const string Subscriptions_Title = "Subscriptions_Title";
				public const string Subscription_PaymentMethod = "Subscription_PaymentMethod";
				public const string Subscription_PaymentMethod_Date = "Subscription_PaymentMethod_Date";
				public const string Subscription_PaymentMethod_Expires = "Subscription_PaymentMethod_Expires";
				public const string Subscription_PaymentMethod_Help = "Subscription_PaymentMethod_Help";
				public const string Subscription_PaymentMethod_Status = "Subscription_PaymentMethod_Status";
				public const string Subscription_Status = "Subscription_Status";
				public const string ModuleCategory_Admin = "ModuleCategory_Admin";
				public const string ModuleCategory_Admin_Summary = "ModuleCategory_Admin_Summary";
				public const string ModuleCategory_IoT = "ModuleCategory_IoT";
				public const string ModuleCategory_IoT_Summary = "ModuleCategory_IoT_Summary";
				public const string Modules_Title = "Modules_Title";
				public const string AppUser_SSN = "AppUser_SSN";
				public const string AppUser_SSN_Help = "AppUser_SSN_Help";
				public const string Common_Icon = "Common_Icon";
				public const string Organization_Logo_Light = "Organization_Logo_Light";
				public const string Organization_TagLine = "Organization_TagLine";
				public const string Organization_DefaultTheme = "Organization_DefaultTheme";
				public const string HolidaySets_Title = "HolidaySets_Title";
				public const string DistroLists_Name = "DistroLists_Name";
				public const string ScheduledDowntimes_Title = "ScheduledDowntimes_Title";
				public const string ScheduledDowntime_DayOfWeek_Select = "ScheduledDowntime_DayOfWeek_Select";
				public const string DownTimeType_WorkWeek = "DownTimeType_WorkWeek";
				public const string ScheduledDowntimePeriod_EndOfDay = "ScheduledDowntimePeriod_EndOfDay";
				public const string ScheduledDowntimePeriod_StartOfDay = "ScheduledDowntimePeriod_StartOfDay";
				public const string ScheduledDowntimePeriod_EndOfDay_Help = "ScheduledDowntimePeriod_EndOfDay_Help";
				public const string ScheduledDowntimePeriod_InvalidTimeFormat = "ScheduledDowntimePeriod_InvalidTimeFormat";
				public const string ScheduledDowntimePeriod_StartOfDay_Help = "ScheduledDowntimePeriod_StartOfDay_Help";
				public const string ScheduleType_WeekDay = "ScheduleType_WeekDay";
				public const string ScheduleType_WeekEnd = "ScheduleType_WeekEnd";
				public const string AuthenticationLogs_Description = "AuthenticationLogs_Description";
				public const string AuthenticationLogs_Title = "AuthenticationLogs_Title";
				public const string AppUser_EmailSignature = "AppUser_EmailSignature";
				public const string Location_RoomNumber = "Location_RoomNumber";
				public const string Organization_DefaultInstance = "Organization_DefaultInstance";
				public const string Organization_DefaultInstance_Select = "Organization_DefaultInstance_Select";
				public const string Organization_DefaultRepo = "Organization_DefaultRepo";
				public const string Organization_DefaultRepo_Select = "Organization_DefaultRepo_Select";
				public const string Organization_Locations_Title = "Organization_Locations_Title";
				public const string OrgLocation_AdminContact_Select = "OrgLocation_AdminContact_Select";
				public const string OrgLocation_TechnicalContact_Select = "OrgLocation_TechnicalContact_Select";
				public const string DistributionList_ExternalContacts = "DistributionList_ExternalContacts";
				public const string ExternalContact_SendEmail = "ExternalContact_SendEmail";
				public const string ExternalContact_SendSMS = "ExternalContact_SendSMS";
				public const string LocationDiagrams_Description = "LocationDiagrams_Description";
				public const string LocationDiagrams_Title = "LocationDiagrams_Title";
				public const string LocationDiagram_BaseLocation = "LocationDiagram_BaseLocation";
				public const string LocationDiagram_BaseLocation_Help = "LocationDiagram_BaseLocation_Help";
				public const string LocationDiagram_Shape = "LocationDiagram_Shape";
				public const string LocationDiagram_Shape_Help = "LocationDiagram_Shape_Help";
				public const string LocationDiagram_Shape_OrgLocation = "LocationDiagram_Shape_OrgLocation";
				public const string LocationDiagram_Shape_OrgLocation_Help = "LocationDiagram_Shape_OrgLocation_Help";
				public const string LocationDiagram_Title = "LocationDiagram_Title";
				public const string Common_SelectDevice = "Common_SelectDevice";
				public const string Common_SelectLocation = "Common_SelectLocation";
				public const string LocationDiagram_Height = "LocationDiagram_Height";
				public const string LocationDiagram_Left = "LocationDiagram_Left";
				public const string LocationDiagram_Top = "LocationDiagram_Top";
				public const string LocationDiagram_Width = "LocationDiagram_Width";
				public const string ShapeType = "ShapeType";
				public const string ShapeType_Building = "ShapeType_Building";
				public const string ShapeType_Closet = "ShapeType_Closet";
				public const string ShapeType_Door = "ShapeType_Door";
				public const string ShapeType_ExternalEntrance = "ShapeType_ExternalEntrance";
				public const string ShapeType_ParkingLot = "ShapeType_ParkingLot";
				public const string ShapeType_Room = "ShapeType_Room";
				public const string ShapeType_Select = "ShapeType_Select";
				public const string ShapeType_Window = "ShapeType_Window";
				public const string ShapeType_Circle = "ShapeType_Circle";
				public const string Shape_Fill = "Shape_Fill";
				public const string Shape_FlipX = "Shape_FlipX";
				public const string Shape_FlipY = "Shape_FlipY";
				public const string Shape_Rotation = "Shape_Rotation";
				public const string Shape_Scale = "Shape_Scale";
				public const string Shape_Stroke = "Shape_Stroke";
				public const string LocationDiagramShapeGroup_Description = "LocationDiagramShapeGroup_Description";
				public const string LocationDiagramShapeGroup_Shapes = "LocationDiagramShapeGroup_Shapes";
				public const string LocationDiagramShapeGroup_Title = "LocationDiagramShapeGroup_Title";
				public const string LocationDiagram_Groups = "LocationDiagram_Groups";
				public const string LocationDiagram_Shapes = "LocationDiagram_Shapes";
				public const string LocationDiagramLayer_Description = "LocationDiagramLayer_Description";
				public const string LocationDiagramLayer_Shapes = "LocationDiagramLayer_Shapes";
				public const string LocationDiagramLayer_Title = "LocationDiagramLayer_Title";
				public const string LocationDiagramShapeGroup_Help = "LocationDiagramShapeGroup_Help";
				public const string LocationDiagram_Layers = "LocationDiagram_Layers";
				public const string LocationDiagramLayer_Groups = "LocationDiagramLayer_Groups";
				public const string LocationDiagramLayer_Locked = "LocationDiagramLayer_Locked";
				public const string LocationDiagramLayer_Visible = "LocationDiagramLayer_Visible";
				public const string ShapeType_Polygon = "ShapeType_Polygon";
				public const string Shape_Locked = "Shape_Locked";
				public const string Organizations_Title = "Organizations_Title";
				public const string OrgLocation_PhoneNumber = "OrgLocation_PhoneNumber";
				public const string Organization_IsForProductLine = "Organization_IsForProductLine";
				public const string Area_IsForProductLine = "Area_IsForProductLine";
				public const string Module_IsForProductLine = "Module_IsForProductLine";
				public const string Page_IsForProductLine = "Page_IsForProductLine";
				public const string Organization_AccentColor = "Organization_AccentColor";
				public const string Organization_Details = "Organization_Details";
				public const string Organization_HeroBackground = "Organization_HeroBackground";
				public const string Organization_HeroTitle = "Organization_HeroTitle";
				public const string Common_PrimaryBgColor = "Common_PrimaryBgColor";
				public const string Common_PrimaryTextColor = "Common_PrimaryTextColor";
				public const string Organization_SalesContact = "Organization_SalesContact";
				public const string Organization_SubLocation = "Organization_SubLocation";
				public const string Organization_SubLocations = "Organization_SubLocations";
				public const string Organization_SubLocation_Details = "Organization_SubLocation_Details";
				public const string DeviceOwnersDevices_Description = "DeviceOwnersDevices_Description";
				public const string DeviceOwnersDevices_Device = "DeviceOwnersDevices_Device";
				public const string DeviceOwnersDevices_DeviceId = "DeviceOwnersDevices_DeviceId";
				public const string DeviceOwnersDevices_DeviceRepository = "DeviceOwnersDevices_DeviceRepository";
				public const string DeviceOwnersDevices_Organization = "DeviceOwnersDevices_Organization";
				public const string DeviceOwnersDevices_Title = "DeviceOwnersDevices_Title";
				public const string DeviceOwners_Title = "DeviceOwners_Title";
				public const string DeviceOwner_Description = "DeviceOwner_Description";
				public const string DeviceOwner_Devices = "DeviceOwner_Devices";
				public const string DeviceOwner_EmailAddress = "DeviceOwner_EmailAddress";
				public const string DeviceOwner_FirstName = "DeviceOwner_FirstName";
				public const string DeviceOwner_LastName = "DeviceOwner_LastName";
				public const string DeviceOwner_Password = "DeviceOwner_Password";
				public const string DeviceOwner_Password_Confirm = "DeviceOwner_Password_Confirm";
				public const string DeviceOwner_PhoneNumber = "DeviceOwner_PhoneNumber";
				public const string DeviceOwner_Title = "DeviceOwner_Title";
				public const string ExternalContact_Description = "ExternalContact_Description";
				public const string ExternalContact_Title = "ExternalContact_Title";
				public const string Common_TimeZome = "Common_TimeZome";
				public const string Organization_Logo_DarkColor = "Organization_Logo_DarkColor";
				public const string Organization_Logo_DarkColor_Help = "Organization_Logo_DarkColor_Help";
				public const string Organization_Logo_LightColor_Help = "Organization_Logo_LightColor_Help";
				public const string DeviceOwnersDevices_Product = "DeviceOwnersDevices_Product";
				public const string Organization_BillingLocation = "Organization_BillingLocation";
				public const string Organization_BillingLocation_Select = "Organization_BillingLocation_Select";
				public const string OrgLocation_GeoBoundingBox = "OrgLocation_GeoBoundingBox";
				public const string OrgLocation_GeoBoundingBox_Help = "OrgLocation_GeoBoundingBox_Help";
				public const string Common_TextColor = "Common_TextColor";
				public const string Common_FillColor = "Common_FillColor";
				public const string Common_StrokeColor = "Common_StrokeColor";
				public const string Shape_TextRotation = "Shape_TextRotation";
				public const string OrgLocation_Diagram = "OrgLocation_Diagram";
				public const string OrgLocation_Diagram_Select = "OrgLocation_Diagram_Select";
				public const string OrgLocation_DeviceRepository = "OrgLocation_DeviceRepository";
				public const string OrgLocation_DeviceRepository_Select = "OrgLocation_DeviceRepository_Select";
				public const string AppUser_PrimaryOrganization = "AppUser_PrimaryOrganization";
				public const string AppUser_PrimaryOrganization_Help = "AppUser_PrimaryOrganization_Help";
				public const string Common_Customer = "Common_Customer";
				public const string LocationDiagram_Shape_CustomerLocation = "LocationDiagram_Shape_CustomerLocation";
				public const string LocationDiagram_Shape_CustomerLocation_Help = "LocationDiagram_Shape_CustomerLocation_Help";
				public const string DistroList_ParentList = "DistroList_ParentList";
				public const string DistroList_ParentList_Help = "DistroList_ParentList_Help";
				public const string Organization_DefaultDemoInstance = "Organization_DefaultDemoInstance";
				public const string Organization_DefaultDevelopmentInstance = "Organization_DefaultDevelopmentInstance";
				public const string Organization_DefaultTestInstance = "Organization_DefaultTestInstance";
				public const string OrgLocation_DistributionList = "OrgLocation_DistributionList";
				public const string OrgLocation_DistributionList_Select = "OrgLocation_DistributionList_Select";
				public const string OrgLocation_PrimaryDevice = "OrgLocation_PrimaryDevice";
				public const string OrgLocation_PrimaryDevice_Select = "OrgLocation_PrimaryDevice_Select";
				public const string Module_RootPath = "Module_RootPath";
				public const string Module_RootPath_Help = "Module_RootPath_Help";
				public const string ContactList_Title = "ContactList_Title";
				public const string ContactList_Description = "ContactList_Description";
			}
	}
}
