using System;
using System.Windows.Forms;
using SampleClientForRateQuoteWebService.RateQuoteWebServiceReference;
using System.Reflection;
using System.Data;
namespace SampleClientForRateQuoteWebService
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// The username.
		/// </summary>
		private string Username = "brownjordan6";

		/// <summary>
		/// The password.
		/// </summary>
		private string Password = "Thursday%27";

		/// <summary>
		/// Initializes a new instance of the <see cref="Form1"/> class.
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event of the btnRateMyShipment control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnRateMyShipment_Click(object sender, EventArgs e)
		{
			QuoteInfo quoteInfo = new QuoteInfo();
			QuoteItemsInfo[] quoteItemsInfo;

			FillQuoteDetails(out quoteInfo, out quoteItemsInfo);

			RateQuoteWebServiceReference.Service rateQuoteWebService = new RateQuoteWebServiceReference.Service();
			QuoteRates[] quoteRates = null;
			quoteRates = rateQuoteWebService.RateMyShipment(quoteInfo, quoteItemsInfo);
			if (quoteRates != null)
			{
				dgvRateMyShipment.DataSource = quoteRates;
			}
			else
			{
				dgvRateMyShipment.DataSource = null;
				MessageBox.Show("No carriers Found");
			}
		}

		/// <summary>
		/// Fills the quote details.
		/// </summary>
		/// <param name="quoteInfo">The quote information.</param>
		/// <param name="quoteItemsInfo">The quote items information.</param>
		private void FillQuoteDetails(out QuoteInfo quoteInfo, out QuoteItemsInfo[] quoteItemsInfo)
		{
			// Quote Info.
			quoteInfo = new QuoteInfo();
			quoteInfo.ShipmentOriginZip = "98001";
			quoteInfo.ShipmentDestinationZip = "10001";
			quoteInfo.ShipmentRequestDate = DateTime.Today;
			quoteInfo.ShipperUserNameWithCarrierRate = Username;
			quoteInfo.ShipperPasswordWithCarrierRate = Password;
			quoteInfo.ShipmentDropoffService = DropoffTypes.None;
			quoteInfo.ShipmentPickupService = PickupTypes.None;
			quoteInfo.IsInsidePickup = false;
			quoteInfo.IsExtremeLength = false;
			quoteInfo.ExtremeLength = 0;
			quoteInfo.ExtremeLengthBundleCount = 0;
			quoteInfo.IsTradeShow = false;
			quoteInfo.IsSortnSegregate = false;
			quoteInfo.isInsuranceRequired = false;
			quoteInfo.isNewItem = false;
			quoteInfo.RequiredInsuranceAmount = 0;
			quoteInfo.ShipmentExtraService = ExtraServices.None;
			quoteInfo.NonCommercialDeliveryType = NonCommercialDeliveryTypes.None;
			quoteInfo.IsProtectFromFreeze = false;

			// Quote Items Info.
			quoteItemsInfo = new QuoteItemsInfo[1];
			quoteItemsInfo[0] = new QuoteItemsInfo();
			quoteItemsInfo[0].FAKClass = 50;
			quoteItemsInfo[0].Hazardous = false;
			quoteItemsInfo[0].ItemHeight = 0;
			quoteItemsInfo[0].ItemLength = 0;
			quoteItemsInfo[0].ItemNmfc = "85";
			quoteItemsInfo[0].ItemWeight = 500;
			quoteItemsInfo[0].ItemWidth = 0;
			quoteItemsInfo[0].PackageTypeId = 0;
			quoteItemsInfo[0].PackageTypeName = "Pallets(40x48)";
			quoteItemsInfo[0].PalletCount = 0;
			quoteItemsInfo[0].PieceDescription = "Boxes";
			quoteItemsInfo[0].Pieces = 1;
			quoteItemsInfo[0].ProductId = 1;
		}

		/// <summary>
		/// Handles the Click event of the btnConfirmShipment control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnConfirmShipment_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtIndex.Text))
			{
				MessageBox.Show("Carrier Index is Empty.");
				txtIndex.Focus();
			}
			else
			{
				RateQuoteWebServiceReference.Service rateQuoteWebService = new RateQuoteWebServiceReference.Service();

				Int32 productsCount;
				productsCount = 1;

				QuoteItemsInfo[] quoteItemsInfo = new QuoteItemsInfo[productsCount];
				quoteItemsInfo = InsertIntoQuoteItems(productsCount, quoteItemsInfo);

				ConfirmQuoteRequestInfo confirmation = new ConfirmQuoteRequestInfo();
				confirmation.AgreementAcceptance = true;
				confirmation.DeliveryRemarks = "test remark";
				confirmation.PickUpRemarks = "test remark";
				confirmation.PONo = "1000000";
				confirmation.QuoteItems = quoteItemsInfo;
				string RedayTime = string.Concat("07:00 PM");
				string CloseTime = string.Concat("09:00 PM");
				confirmation.ShipmentCloseTime = CloseTime;
				confirmation.ShipmentReadyTime = RedayTime;
				confirmation.ShipmentDate = DateTime.Now.AddDays(1);

				int index = Convert.ToInt32(txtIndex.Text);
				confirmation.SelectedCarrierCodeForShipment = dgvRateMyShipment.Rows[index].Cells[1].Value.ToString();
				confirmation.ServiceTransactionId = dgvRateMyShipment.Rows[index].Cells["ServiceTransactionId"].Value.ToString();
				confirmation.RefrenceNumber = "";
				confirmation.CustomerBOL = "";
				confirmation.ConsigneeAddress = new ShipmentAddress();
				confirmation.ConsigneeAddress.CompanyName = "Asik comp 1";
				confirmation.ConsigneeAddress.ContactPerson = "Asik AMjad 1";
				confirmation.ConsigneeAddress.Street = "1st street";
				confirmation.ConsigneeAddress.Fax = "";
				confirmation.ConsigneeAddress.Phone = "1234567890";
				confirmation.ConsigneeAddress.PhoneExtention = "1234";
				confirmation.ConsigneeAddress.City = "Auburn";
				confirmation.ConsigneeAddress.State = "WA";
				confirmation.ConsigneeAddress.ZipCode = "980001";
				confirmation.ConsigneeAddress.Country = "USA";

				confirmation.ShipperAddress = new ShipmentAddress();
				confirmation.ShipperAddress.CompanyName = "Asik Comp 2";
				confirmation.ShipperAddress.ContactPerson = "Asik AMjad 2";
				confirmation.ShipperAddress.Street = "2nd street";
				confirmation.ShipperAddress.Fax = "1111111111";
				confirmation.ShipperAddress.Phone = "2222222222";
				confirmation.ConsigneeAddress.PhoneExtention = "1234";
				confirmation.ShipperAddress.City = "Los Angeles";
				confirmation.ShipperAddress.State = "CA";
				confirmation.ShipperAddress.ZipCode = "10001";
				confirmation.ShipperAddress.Country = "USA";

				rateQuoteWebService.ConfirmShipmentCompleted += new ConfirmShipmentCompletedEventHandler(ser_ConfirmShipmentCompleted);

				textBoxBolNo.Text = Convert.ToString(rateQuoteWebService.ConfirmShipment(confirmation));
			}
		}

		/// <summary>
		/// Inserts the into quote items.
		/// </summary>
		/// <param name="productsCount">The products count.</param>
		/// <param name="quoteItemsInfo">The quote items information.</param>
		/// <returns></returns>
		public QuoteItemsInfo[] InsertIntoQuoteItems(Int32 productsCount, QuoteItemsInfo[] quoteItemsInfo)
		{
			quoteItemsInfo[0] = new QuoteItemsInfo();

			quoteItemsInfo[0].FAKClass = 50;
			quoteItemsInfo[0].Hazardous = false;

			quoteItemsInfo[0].ItemHeight = 0;
			quoteItemsInfo[0].ItemWidth = 0;
			quoteItemsInfo[0].ItemLength = 0;

			quoteItemsInfo[0].ItemNmfc = "85";
			quoteItemsInfo[0].ItemWeight = 500;

			quoteItemsInfo[0].PackageTypeId = 0;
			quoteItemsInfo[0].PackageTypeName = "";
			quoteItemsInfo[0].ProductId = 1;

			quoteItemsInfo[0].Pieces = 1;
			quoteItemsInfo[0].PieceDescription = "Boxes";
			return quoteItemsInfo;
		}

		/// <summary>
		/// Handles the ConfirmShipmentCompleted event of the ser control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="ConfirmShipmentCompletedEventArgs"/> instance containing the event data.</param>
		void ser_ConfirmShipmentCompleted(object sender, ConfirmShipmentCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				string bolNo = Convert.ToString(e.Result);
				textBoxBolNo.Text = bolNo.ToString();

			}
			else
			{
				MessageBox.Show(e.Error.Message);
			}
		}

		/// <summary>
		/// Handles the Click event of the btnMyShipmentTrack control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnMyShipmentTrack_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxBolNo.Text))
			{
				MessageBox.Show("No Shipment available.");
			}
			else
			{
				RateQuoteWebServiceReference.Service rateQuoteWebService = new RateQuoteWebServiceReference.Service();

				TrackingInfo trackingInfo = new TrackingInfo();
				trackingInfo = rateQuoteWebService.GetMyShipmentTrack(Username, Password, textBoxBolNo.Text, "True");

				DataTable trackingDatatable = new System.Data.DataTable();

				foreach (PropertyInfo info in typeof(TrackingInfo).GetProperties())
				{
					trackingDatatable.Columns.Add(info.Name, info.PropertyType);
				}

				trackingDatatable.AcceptChanges();
				DataRow trackingRow = trackingDatatable.NewRow();

				foreach (var property in trackingInfo.GetType().GetProperties())
				{
					trackingRow[property.Name] = property.GetValue(trackingInfo, null);
				}

				trackingDatatable.Rows.Add(trackingRow);
				trackingDatatable.AcceptChanges();

				dgvShipmentTrack.DataSource = trackingDatatable;
			}
		}
	}
}
