## 1. AppointmentDesk

**Responsibilities:**
	- **Business Hours Policy:** Defines and validates clinic working hours.
	- **Appointment Scheduling:** Searches for available slots and manages bookings.
	- **ICS Calendar Export:** Generates calendar events.
	- **SMS Reminder Formatting:** Creates reminder messages.

Why is this a problem?
	- The class combines scheduling, clinic policies, calendar export, and SMS formatting.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 2. CheckoutBasket

**Responsibilities:**
- **Basket Management:** Adds and stores products and quantities.
- **Pricing Calculations:** Calculates subtotals, discounts, and final totals.
- **Coupon Processing:** Parses coupon text and determines applicable discounts.
- **Gift-Wrap Policy:** Applies additional packaging fees.
- **Gift Message Generation:** Creates personalized gift cards.
- **Payment Authorization:** Generates simulated payment authorization codes.

**Why is this a problem?**
	- The class mixes basket management, pricing, coupon parsing, gift messaging, and payment processing.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 3. CourseEnrollmentDesk

**Responsibilities:**
	- **Enrollment Management:** Registers students and prevents duplicate registrations.
	- **Capacity and Waitlist Management:** Assigns seats, tracks waitlist positions, and promotes students.
	- **Welcome Packet Generation:** Generates personalized Markdown welcome messages.
	- **Tuition Invoice Generation:** Calculates VAT and formats tuition invoice lines.

**Why is this a problem?**
	- The class combines enrollment rules, waitlist operations, welcome content, and financial calculations.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 4. GradeBook

**Responsibilities:**
	- **Grade Management:** Records and stores student scores.
	- **Grade Calculation:** Calculates students' average scores.
	- **Academic Policy:** Assigns letter grades and determines honor roll eligibility.
	- **Transcript Generation:** Generates plain-text transcripts.
	- **CSV Export:** Exports student grades and academic results to CSV.

**Why is this a problem?**
	- The class combines score management, academic rules, and document generation.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 5. KitchenTicket

**Responsibilities:**
	- **Order Management:** Stores food items, ingredients, and preparation times.
	- **Allergen Detection:** Identifies allergens based on ingredient names.
	- **Preparation Time Estimation:** Estimates order readiness based on cooking stations and allergy delays.
	- **Ticket Printing:** Formats order details and allergens for thermal printers.
	- **Kitchen Routing:** Determines the appropriate kitchen lane based on allergens and preparation time.

**Why is this a problem?**
	- The class combines order data, allergen rules, timing calculations, printer formatting, and kitchen routing.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 6. LoanDesk

**Responsibilities:**
	- **Risk Assessment:** Calculates risk scores and determines loan eligibility.
	- **Document Requirements:** Determines the documents required based on loan conditions and eligibility.
	- **Decision Letter Generation:** Creates approval or rejection letters for applicants.
	- **CSV Export:** Formats loan application data for underwriting reports.

**Why is this a problem?**
	- The class combines loan assessment, compliance requirements, communication, and data export.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 7. SubscriptionBilling

**Responsibilities:**
	- **Proration Calculation:** Calculates subscription charges based on active dates.
	- **Invoice Number Generation:** Generates sequential invoice numbers.
	- **Payment Tracking:** Tracks failed payment attempts.
	- **Dunning Email Generation:** Creates payment reminder emails based on failure history.
	- **Ledger Export:** Formats subscription charges for accounting records.

**Why is this a problem?**
	- The class combines billing calculations, invoice numbering, payment tracking, email communication, and accounting exports.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 8. SupportTicket

**Responsibilities:**
	- **Ticket Management:** Stores ticket details and appends customer messages.
	- **Priority Classification:** Determines ticket priority using text keywords.
	- **SLA Management:** Calculates response deadlines and checks for breaches.
	- **Public Reply Generation:** Creates customer-facing responses.
	- **Internal Escalation Formatting:** Generates escalation summaries for support staff.

**Why is this a problem?**
	- The class combines ticket data management, text analysis, SLA rules, and message formatting.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 9. WardBoard

**Responsibilities:**
	- **Bed Management:** Assigns patients to beds and stores patient information.
	- **Clinical Assessment:** Calculates patient acuity scores from vital signs.
	- **Pager Alerts:** Determines when to trigger alerts and maintains the pager log.
	- **Nurse Handoff Notes:** Generates patient status summaries for nurses.
	- **Census Export:** Exports bed and patient data to CSV.

**Why is this a problem?**
	- The class combines patient tracking, clinical assessment, alerting, report generation, and data export.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________

## 10. WarehousePickList

**Responsibilities:**
	- **Pick List Management:** Stores required quantities and available stock.
	- **Stock Allocation:** Calculates allocated quantities based on stock availability.
	- **Walking Order Optimization:** Sorts items by aisle and bin location.
	- **Picker Instructions:** Generates picking steps and shortage warnings.
	- **WMS XML Export:** Formats allocation data for warehouse management system integration.

**Why is this a problem?**
	- The class combines stock allocation, warehouse navigation, instruction formatting, and XML integration.
	- Each may change for a different reason, making the class harder to maintain and violating SRP.

________________________________________________________________________________________________________________________