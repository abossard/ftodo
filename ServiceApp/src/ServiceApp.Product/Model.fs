module ServiceApp.Product.Model

open System

type PersonalName =
    {
    FirstName: string;
    MiddleInitial: string option;
    LastName: string;
    }

type PostalAddress =
    {
    Address1: string;
    Address2: string;
    City: string;
    State: string;
    Zip: string;
    }

    
type ProductInformation = GoodsProduct | ServiceProduct | DigitalProduct

type Product =
    {
        title: string
        information: ProductInformation
    }

type GoodsProduct =
    {
        shippingLocation: string
    }

type ServiceDeliverySlot = CalendarEntry | None

type ServiceProduct =
    {
        deliverySlot: ServiceDeliverySlot
    }

type DigitalProduct =
    {
        downloadUrl: Uri
    }