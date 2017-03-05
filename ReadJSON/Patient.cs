using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJSON
{
    public class Patient
    {
        public string AddressCity { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressStateCode { get; set; }
        public string AddressZipCode { get; set; }
        public Guid AdmissionId { get; set; }
        public string AdmissionSource { get; set; }
        public Guid AgencyId { get; set; }
        public Guid AgencyLocationId { get; set; }
        public Guid CaseManagerId { get; set; }
        public string Comments { get; set; }
        public DateTime Created { get; set; }
        public DateTime DischargeDate { get; set; }
        public string DischargeReason { get; set; }
        public int DischargeReasonId { get; set; }
        public string DME { get; set; }
        public DateTime DOB { get; set; }
        public string EmailAddress { get; set; }
        public string Ethnicities { get; set; }
        public string EvacuationZone { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public int HeightMetric { get; set; }
        public Guid HospitalizationId { get; set; }
        public Guid Id { get; set; }
        public Guid InternalReferral { get; set; }
        public bool IsDeprecated { get; set; }
        public bool IsHospitalized { get; set; }
        public DateTime LastEligibilityCheck { get; set; }
        public string LastName { get; set; }
        public string MaritalStatus { get; set; }
        public string MedicaidNumber { get; set; }
        public string MedicareNumber { get; set; }
        public string MiddleInitial { get; set; }
        public DateTime Modified { get; set; }
        public DateTime NonAdmissionDate { get; set; }
        public string NonAdmissionReason { get; set; }
        public string OtherDME { get; set; }
        public string OtherPaymentSource { get; set; }
        public string OtherReferralSource { get; set; }
        public string PatientIdNumber { get; set; }
        public string Payer { get; set; }
        public string PaymentSource { get; set; }
        public string PharmacyName { get; set; }
        public string PharmacyPhone { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public Guid PhotoId { get; set; }
        public string PrimaryGroupId { get; set; }
        public string PrimaryGroupName { get; set; }
        public string PrimaryHealthPlanId { get; set; }
        public string PrimaryInsurance { get; set; }
        public DateTime ReferralDate { get; set; }
        public Guid ReferrerPhysician { get; set; }
        public string SecondaryGroupId { get; set; }
        public string SecondaryGroupName { get; set; }
        public string SecondaryHealthPlanId { get; set; }
        public string SecondaryInsurance { get; set; }
        public string ServicesRequired { get; set; }
        public string SSN { get; set; }
        public DateTime StartofCareDate { get; set; }
        public int Status { get; set; }
        public string TertiaryGroupId { get; set; }
        public string TertiaryGroupName { get; set; }
        public string TertiaryHealthPlanId { get; set; }
        public string TertiaryInsurance { get; set; }
        public int Triage { get; set; }
        public Guid UserId { get; set; }
        public float Weight { get; set; }
        public int WeightMetric { get; set; }
    }
}
