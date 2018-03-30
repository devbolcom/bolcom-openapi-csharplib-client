using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Generic;


public partial class Login
{

    private string sessionIdField;

    private string nameField;

    private bool mergedBasketField;

    public string SessionId
    {
        get
        {
            return this.sessionIdField;
        }
        set
        {
            this.sessionIdField = value;
        }
    }

    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    public bool MergedBasket
    {
        get
        {
            return this.mergedBasketField;
        }
        set
        {
            this.mergedBasketField = value;
        }
    }
}

public partial class RequestAuthToken
{

    private string privateTokenField;

    private string codeField;

    private string urlField;

    public string PrivateToken
    {
        get
        {
            return this.privateTokenField;
        }
        set
        {
            this.privateTokenField = value;
        }
    }

    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    public string Url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }
}

public partial class Session
{

    private string sessionIdField;

    public string SessionId
    {
        get
        {
            return this.sessionIdField;
        }
        set
        {
            this.sessionIdField = value;
        }
    }
}

public partial class ProductList
{

    private List<Product> productsField;

    public ProductList()
    {
        this.productsField = new List<Product>();
    }

    public List<Product> Products
    {
        get
        {
            return this.productsField;
        }
        set
        {
            this.productsField = value;
        }
    }
}

public partial class Product
{

    private string idField;

    private string eANField;

    private string gPCField;

    private string titleField;

    private string subtitleField;

    private string summaryField;

    private int ratingField;

    private bool ratingFieldSpecified;

    private string shortDescriptionField;

    private string longDescriptionField;

    private List<TrackList> trackListsField;

    private List<AttributeGroup> attributeGroupsField;

    private List<EntityGroup> entityGroupsField;

    private List<Entry> urlsField;

    private List<MediaEntry> imagesField;

    private List<MediaEntry> mediaField;

    private OfferData offerDataField;

    private List<Promotion> promotionsField;

    private List<ParentCategory> parentCategoryPathsField;

    public Product()
    {
        this.parentCategoryPathsField = new List<ParentCategory>();
        this.promotionsField = new List<Promotion>();
        this.offerDataField = new OfferData();
        this.mediaField = new List<MediaEntry>();
        this.imagesField = new List<MediaEntry>();
        this.urlsField = new List<Entry>();
        this.entityGroupsField = new List<EntityGroup>();
        this.attributeGroupsField = new List<AttributeGroup>();
        this.trackListsField = new List<TrackList>();
    }

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string EAN
    {
        get
        {
            return this.eANField;
        }
        set
        {
            this.eANField = value;
        }
    }

    public string GPC
    {
        get
        {
            return this.gPCField;
        }
        set
        {
            this.gPCField = value;
        }
    }

    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    public string Subtitle
    {
        get
        {
            return this.subtitleField;
        }
        set
        {
            this.subtitleField = value;
        }
    }

    public string Summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    public int Rating
    {
        get
        {
            return this.ratingField;
        }
        set
        {
            this.ratingField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RatingSpecified
    {
        get
        {
            return this.ratingFieldSpecified;
        }
        set
        {
            this.ratingFieldSpecified = value;
        }
    }

    public string ShortDescription
    {
        get
        {
            return this.shortDescriptionField;
        }
        set
        {
            this.shortDescriptionField = value;
        }
    }

    public string LongDescription
    {
        get
        {
            return this.longDescriptionField;
        }
        set
        {
            this.longDescriptionField = value;
        }
    }

    public List<TrackList> TrackLists
    {
        get
        {
            return this.trackListsField;
        }
        set
        {
            this.trackListsField = value;
        }
    }

    public List<AttributeGroup> AttributeGroups
    {
        get
        {
            return this.attributeGroupsField;
        }
        set
        {
            this.attributeGroupsField = value;
        }
    }

    public List<EntityGroup> EntityGroups
    {
        get
        {
            return this.entityGroupsField;
        }
        set
        {
            this.entityGroupsField = value;
        }
    }

    public List<Entry> Urls
    {
        get
        {
            return this.urlsField;
        }
        set
        {
            this.urlsField = value;
        }
    }

    public List<MediaEntry> Images
    {
        get
        {
            return this.imagesField;
        }
        set
        {
            this.imagesField = value;
        }
    }

    public List<MediaEntry> Media
    {
        get
        {
            return this.mediaField;
        }
        set
        {
            this.mediaField = value;
        }
    }

    public OfferData OfferData
    {
        get
        {
            return this.offerDataField;
        }
        set
        {
            this.offerDataField = value;
        }
    }

    public List<Promotion> Promotions
    {
        get
        {
            return this.promotionsField;
        }
        set
        {
            this.promotionsField = value;
        }
    }

    [System.Xml.Serialization.XmlArrayAttribute(Order = 17)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ParentCategories", typeof(ParentCategory), IsNullable = false)]
    public List<ParentCategory> ParentCategoryPaths
    {
        get
        {
            return this.parentCategoryPathsField;
        }
        set
        {
            this.parentCategoryPathsField = value;
        }
    }
}

public partial class TrackList
{

    private int discNumberField;

    private List<Track> trackField;

    public TrackList()
    {
        this.trackField = new List<Track>();
    }

    public int DiscNumber
    {
        get
        {
            return this.discNumberField;
        }
        set
        {
            this.discNumberField = value;
        }
    }

    public List<Track> Track
    {
        get
        {
            return this.trackField;
        }
        set
        {
            this.trackField = value;
        }
    }
}

public partial class Track
{

    private string titleField;

    private int trackNumberField;

    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    public int TrackNumber
    {
        get
        {
            return this.trackNumberField;
        }
        set
        {
            this.trackNumberField = value;
        }
    }
}

public partial class AttributeGroup
{

    private string titleField;

    private List<Entry> attributesField;

    public AttributeGroup()
    {
        this.attributesField = new List<Entry>();
    }

    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    public List<Entry> Attributes
    {
        get
        {
            return this.attributesField;
        }
        set
        {
            this.attributesField = value;
        }
    }
}

public partial class Entry
{

    private string keyField;

    private string labelField;

    private string valueField;

    public string Key
    {
        get
        {
            return this.keyField;
        }
        set
        {
            this.keyField = value;
        }
    }

    public string Label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

public partial class EntityGroup
{

    private string titleField;

    private List<Entity> entitiesField;

    public EntityGroup()
    {
        this.entitiesField = new List<Entity>();
    }

    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    public List<Entity> Entities
    {
        get
        {
            return this.entitiesField;
        }
        set
        {
            this.entitiesField = value;
        }
    }
}

public partial class Entity
{

    private string idField;

    private string labelField;

    private string valueField;

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string Label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

public partial class MediaEntry
{

    private string typeField;

    private string keyField;

    private string urlField;

    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    public string Key
    {
        get
        {
            return this.keyField;
        }
        set
        {
            this.keyField = value;
        }
    }

    public string Url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }
}

public partial class OfferData
{

    private int bolcomField;

    private bool bolcomFieldSpecified;

    private int nonProfessionalSellersField;

    private bool nonProfessionalSellersFieldSpecified;

    private int professionalSellersField;

    private bool professionalSellersFieldSpecified;

    private List<Offer> offersField;

    public OfferData()
    {
        this.offersField = new List<Offer>();
    }

    public int Bolcom
    {
        get
        {
            return this.bolcomField;
        }
        set
        {
            this.bolcomField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BolcomSpecified
    {
        get
        {
            return this.bolcomFieldSpecified;
        }
        set
        {
            this.bolcomFieldSpecified = value;
        }
    }

    public int NonProfessionalSellers
    {
        get
        {
            return this.nonProfessionalSellersField;
        }
        set
        {
            this.nonProfessionalSellersField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NonProfessionalSellersSpecified
    {
        get
        {
            return this.nonProfessionalSellersFieldSpecified;
        }
        set
        {
            this.nonProfessionalSellersFieldSpecified = value;
        }
    }

    public int ProfessionalSellers
    {
        get
        {
            return this.professionalSellersField;
        }
        set
        {
            this.professionalSellersField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ProfessionalSellersSpecified
    {
        get
        {
            return this.professionalSellersFieldSpecified;
        }
        set
        {
            this.professionalSellersFieldSpecified = value;
        }
    }

    public List<Offer> Offers
    {
        get
        {
            return this.offersField;
        }
        set
        {
            this.offersField = value;
        }
    }
}

public partial class Offer
{

    private string idField;

    private string conditionField;

    private double priceField;

    private bool priceFieldSpecified;

    private double listPriceField;

    private bool listPriceFieldSpecified;

    private string availabilityCodeField;

    private string availabilityDescriptionField;

    private string commentField;

    private Seller sellerField;

    public Offer()
    {
        this.sellerField = new Seller();
    }

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string Condition
    {
        get
        {
            return this.conditionField;
        }
        set
        {
            this.conditionField = value;
        }
    }

    public double Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PriceSpecified
    {
        get
        {
            return this.priceFieldSpecified;
        }
        set
        {
            this.priceFieldSpecified = value;
        }
    }

    public double ListPrice
    {
        get
        {
            return this.listPriceField;
        }
        set
        {
            this.listPriceField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ListPriceSpecified
    {
        get
        {
            return this.listPriceFieldSpecified;
        }
        set
        {
            this.listPriceFieldSpecified = value;
        }
    }

    public string AvailabilityCode
    {
        get
        {
            return this.availabilityCodeField;
        }
        set
        {
            this.availabilityCodeField = value;
        }
    }

    public string AvailabilityDescription
    {
        get
        {
            return this.availabilityDescriptionField;
        }
        set
        {
            this.availabilityDescriptionField = value;
        }
    }

    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    public Seller Seller
    {
        get
        {
            return this.sellerField;
        }
        set
        {
            this.sellerField = value;
        }
    }
}

public partial class Seller
{

    private string idField;

    private string sellerTypeField;

    private string displayNameField;

    private int numberOfReviewsField;

    private bool numberOfReviewsFieldSpecified;

    private int overallRatingField;

    private bool overallRatingFieldSpecified;

    private string urlField;

    private string logoField;

    private string emailAddressField;

    private string phoneNumberField;

    private string addressLine1Field;

    private string addressLine2Field;

    private Rating sellerRatingField;

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string SellerType
    {
        get
        {
            return this.sellerTypeField;
        }
        set
        {
            this.sellerTypeField = value;
        }
    }

    public string DisplayName
    {
        get
        {
            return this.displayNameField;
        }
        set
        {
            this.displayNameField = value;
        }
    }

    public int NumberOfReviews
    {
        get
        {
            return this.numberOfReviewsField;
        }
        set
        {
            this.numberOfReviewsField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NumberOfReviewsSpecified
    {
        get
        {
            return this.numberOfReviewsFieldSpecified;
        }
        set
        {
            this.numberOfReviewsFieldSpecified = value;
        }
    }

    public int OverallRating
    {
        get
        {
            return this.overallRatingField;
        }
        set
        {
            this.overallRatingField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OverallRatingSpecified
    {
        get
        {
            return this.overallRatingFieldSpecified;
        }
        set
        {
            this.overallRatingFieldSpecified = value;
        }
    }

    public string Url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    public string Logo
    {
        get
        {
            return this.logoField;
        }
        set
        {
            this.logoField = value;
        }
    }

    public string EmailAddress
    {
        get
        {
            return this.emailAddressField;
        }
        set
        {
            this.emailAddressField = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return this.phoneNumberField;
        }
        set
        {
            this.phoneNumberField = value;
        }
    }

    public string AddressLine1
    {
        get
        {
            return this.addressLine1Field;
        }
        set
        {
            this.addressLine1Field = value;
        }
    }

    public string AddressLine2
    {
        get
        {
            return this.addressLine2Field;
        }
        set
        {
            this.addressLine2Field = value;
        }
    }

    public Rating SellerRating
    {
        get
        {
            return this.sellerRatingField;
        }
        set
        {
            this.sellerRatingField = value;
        }
    }
}

public class Rating
{
    private string ratingMethodField;

    private string sellerRatingField;

    private string productInformationRatingField;

    private string deliveryTimeRatingField;

    private string shippingRatingField;

    private string serviceRatingField;

    public string RatingMethod
    {
        get
        {
            return this.ratingMethodField;
        }
        set
        {
            this.ratingMethodField = value;
        }
    }

    public string SellerRating
    {
        get
        {
            return this.sellerRatingField;
        }
        set
        {
            this.sellerRatingField = value;
        }
    }

    public string ProductInformationRating
    {
        get
        {
            return this.productInformationRatingField;
        }
        set
        {
            this.productInformationRatingField = value;
        }
    }

    public string DeliveryTimeRating
    {
        get
        {
            return this.deliveryTimeRatingField;
        }
        set
        {
            this.deliveryTimeRatingField = value;
        }
    }

    public string ShippingRating
    {
        get
        {
            return this.shippingRatingField;
        }
        set
        {
            this.shippingRatingField = value;
        }
    }

    public string ServiceRating
    {
        get
        {
            return this.serviceRatingField;
        }
        set
        {
            this.serviceRatingField = value;
        }
    }
}

public partial class Promotion
{

    private string titleField;

    private string descriptionField;

    private string urlField;

    private string urlTextField;

    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    public string Url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    public string UrlText
    {
        get
        {
            return this.urlTextField;
        }
        set
        {
            this.urlTextField = value;
        }
    }
}

public partial class ParentCategory
{

    private string idField;

    private string nameField;

    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

public partial class SellerList
{

    private long totalResultSizeField;

    private bool totalResultSizeFieldSpecified;

    private string sellerIdField;

    private List<Product> productsField;

    public SellerList()
    {
        this.productsField = new List<Product>();
    }

    public long TotalResultSize
    {
        get
        {
            return this.totalResultSizeField;
        }
        set
        {
            this.totalResultSizeField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalResultSizeSpecified
    {
        get
        {
            return this.totalResultSizeFieldSpecified;
        }
        set
        {
            this.totalResultSizeFieldSpecified = value;
        }
    }

    public string SellerId
    {
        get
        {
            return this.sellerIdField;
        }
        set
        {
            this.sellerIdField = value;
        }
    }

    public List<Product> Products
    {
        get
        {
            return this.productsField;
        }
        set
        {
            this.productsField = value;
        }
    }
}

public partial class Pong
{

    private string messageField;

    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }
}

public partial class ListResults
{

    private OriginalRequest originalRequestField;

    private long totalResultSizeField;

    private bool totalResultSizeFieldSpecified;

    private List<Product> productsField;

    private List<Category> categoriesField;

    private List<RefinementGroup> refinementGroupsField;

    public ListResults()
    {
        this.refinementGroupsField = new List<RefinementGroup>();
        this.categoriesField = new List<Category>();
        this.productsField = new List<Product>();
        this.originalRequestField = new OriginalRequest();
    }

    public OriginalRequest OriginalRequest
    {
        get
        {
            return this.originalRequestField;
        }
        set
        {
            this.originalRequestField = value;
        }
    }

    public long TotalResultSize
    {
        get
        {
            return this.totalResultSizeField;
        }
        set
        {
            this.totalResultSizeField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalResultSizeSpecified
    {
        get
        {
            return this.totalResultSizeFieldSpecified;
        }
        set
        {
            this.totalResultSizeFieldSpecified = value;
        }
    }

    public List<Product> Products
    {
        get
        {
            return this.productsField;
        }
        set
        {
            this.productsField = value;
        }
    }

    public List<Category> Categories
    {
        get
        {
            return this.categoriesField;
        }
        set
        {
            this.categoriesField = value;
        }
    }

    public List<RefinementGroup> RefinementGroups
    {
        get
        {
            return this.refinementGroupsField;
        }
        set
        {
            this.refinementGroupsField = value;
        }
    }
}

public partial class OriginalRequest
{

    private Category categoryField;

    private List<RefinementGroup> refinementGroupsField;

    public OriginalRequest()
    {
        this.refinementGroupsField = new List<RefinementGroup>();
        this.categoryField = new Category();
    }

    public Category Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    public List<RefinementGroup> RefinementGroups
    {
        get
        {
            return this.refinementGroupsField;
        }
        set
        {
            this.refinementGroupsField = value;
        }
    }
}

public partial class Category
{

    private string idField;

    private string nameField;

    private int productCountField;

    private bool productCountFieldSpecified;

    private List<Refinement> refinementsField;

    public Category()
    {
        this.refinementsField = new List<Refinement>();
    }

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    public int ProductCount
    {
        get
        {
            return this.productCountField;
        }
        set
        {
            this.productCountField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ProductCountSpecified
    {
        get
        {
            return this.productCountFieldSpecified;
        }
        set
        {
            this.productCountFieldSpecified = value;
        }
    }

    public List<Refinement> Refinements
    {
        get
        {
            return this.refinementsField;
        }
        set
        {
            this.refinementsField = value;
        }
    }
}

public partial class Refinement
{

    private string idField;

    private string nameField;

    private long productCountField;

    private bool productCountFieldSpecified;

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    public long ProductCount
    {
        get
        {
            return this.productCountField;
        }
        set
        {
            this.productCountField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ProductCountSpecified
    {
        get
        {
            return this.productCountFieldSpecified;
        }
        set
        {
            this.productCountFieldSpecified = value;
        }
    }
}

public partial class RefinementGroup
{

    private string idField;

    private string nameField;

    private long productCountField;

    private bool productCountFieldSpecified;

    private bool multiSelectField;

    private bool multiSelectFieldSpecified;

    private List<Refinement> refinementsField;

    public RefinementGroup()
    {
        this.refinementsField = new List<Refinement>();
    }

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    public long ProductCount
    {
        get
        {
            return this.productCountField;
        }
        set
        {
            this.productCountField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ProductCountSpecified
    {
        get
        {
            return this.productCountFieldSpecified;
        }
        set
        {
            this.productCountFieldSpecified = value;
        }
    }

    public bool MultiSelect
    {
        get
        {
            return this.multiSelectField;
        }
        set
        {
            this.multiSelectField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MultiSelectSpecified
    {
        get
        {
            return this.multiSelectFieldSpecified;
        }
        set
        {
            this.multiSelectFieldSpecified = value;
        }
    }

    public List<Refinement> Refinements
    {
        get
        {
            return this.refinementsField;
        }
        set
        {
            this.refinementsField = value;
        }
    }
}

public partial class SearchResults
{

    private OriginalRequest originalRequestField;

    private long totalResultSizeField;

    private bool totalResultSizeFieldSpecified;

    private List<Product> productsField;

    private List<Category> categoriesField;

    private List<RefinementGroup> refinementGroupsField;

    public SearchResults()
    {
        this.refinementGroupsField = new List<RefinementGroup>();
        this.categoriesField = new List<Category>();
        this.productsField = new List<Product>();
        this.originalRequestField = new OriginalRequest();
    }

    public OriginalRequest OriginalRequest
    {
        get
        {
            return this.originalRequestField;
        }
        set
        {
            this.originalRequestField = value;
        }
    }

    public long TotalResultSize
    {
        get
        {
            return this.totalResultSizeField;
        }
        set
        {
            this.totalResultSizeField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalResultSizeSpecified
    {
        get
        {
            return this.totalResultSizeFieldSpecified;
        }
        set
        {
            this.totalResultSizeFieldSpecified = value;
        }
    }

    public List<Product> Products
    {
        get
        {
            return this.productsField;
        }
        set
        {
            this.productsField = value;
        }
    }

    public List<Category> Categories
    {
        get
        {
            return this.categoriesField;
        }
        set
        {
            this.categoriesField = value;
        }
    }

    public List<RefinementGroup> RefinementGroups
    {
        get
        {
            return this.refinementGroupsField;
        }
        set
        {
            this.refinementGroupsField = value;
        }
    }
}

public partial class ProductOffers
{

    private OfferData offerDataField;

    public ProductOffers()
    {
        this.offerDataField = new OfferData();
    }

    public OfferData OfferData
    {
        get
        {
            return this.offerDataField;
        }
        set
        {
            this.offerDataField = value;
        }
    }
}

public partial class ProductRecommendations
{

    private List<Product> productsField;

    public ProductRecommendations()
    {
        this.productsField = new List<Product>();
    }

    public List<Product> Products
    {
        get
        {
            return this.productsField;
        }
        set
        {
            this.productsField = value;
        }
    }
}

public partial class Basket
{

    private double totalAmountArticlesField;

    private bool totalAmountArticlesFieldSpecified;

    private double subTotalField;

    private bool subTotalFieldSpecified;

    private double shippingFeeField;

    private bool shippingFeeFieldSpecified;

    private double totalField;

    private bool totalFieldSpecified;

    private double serviceFeeField;

    private bool serviceFeeFieldSpecified;

    private double giftWrapFeeField;

    private bool giftWrapFeeFieldSpecified;

    private Address billingAddressField;

    private Address shippingAddressField;

    private long totalQuantityField;

    private bool totalQuantityFieldSpecified;

    private bool shippableAbroadField;

    private bool shippableAbroadFieldSpecified;

    private bool combinableField;

    private bool combinableFieldSpecified;

    private bool openForUseField;

    private bool openForUseFieldSpecified;

    private List<string> specialRequirementsField;

    private List<string> basketMessagesField;

    private List<BasketItem> basketItemsField;

    private List<PricingAdjustment> pricingAdjustmentsField;

    public Basket()
    {
        this.pricingAdjustmentsField = new List<PricingAdjustment>();
        this.basketItemsField = new List<BasketItem>();
        this.basketMessagesField = new List<string>();
        this.specialRequirementsField = new List<string>();
        this.shippingAddressField = new Address();
        this.billingAddressField = new Address();
    }

    public double TotalAmountArticles
    {
        get
        {
            return this.totalAmountArticlesField;
        }
        set
        {
            this.totalAmountArticlesField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalAmountArticlesSpecified
    {
        get
        {
            return this.totalAmountArticlesFieldSpecified;
        }
        set
        {
            this.totalAmountArticlesFieldSpecified = value;
        }
    }

    public double SubTotal
    {
        get
        {
            return this.subTotalField;
        }
        set
        {
            this.subTotalField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SubTotalSpecified
    {
        get
        {
            return this.subTotalFieldSpecified;
        }
        set
        {
            this.subTotalFieldSpecified = value;
        }
    }

    public double ShippingFee
    {
        get
        {
            return this.shippingFeeField;
        }
        set
        {
            this.shippingFeeField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ShippingFeeSpecified
    {
        get
        {
            return this.shippingFeeFieldSpecified;
        }
        set
        {
            this.shippingFeeFieldSpecified = value;
        }
    }

    public double Total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalSpecified
    {
        get
        {
            return this.totalFieldSpecified;
        }
        set
        {
            this.totalFieldSpecified = value;
        }
    }

    public double ServiceFee
    {
        get
        {
            return this.serviceFeeField;
        }
        set
        {
            this.serviceFeeField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ServiceFeeSpecified
    {
        get
        {
            return this.serviceFeeFieldSpecified;
        }
        set
        {
            this.serviceFeeFieldSpecified = value;
        }
    }

    public double GiftWrapFee
    {
        get
        {
            return this.giftWrapFeeField;
        }
        set
        {
            this.giftWrapFeeField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool GiftWrapFeeSpecified
    {
        get
        {
            return this.giftWrapFeeFieldSpecified;
        }
        set
        {
            this.giftWrapFeeFieldSpecified = value;
        }
    }

    public Address BillingAddress
    {
        get
        {
            return this.billingAddressField;
        }
        set
        {
            this.billingAddressField = value;
        }
    }

    public Address ShippingAddress
    {
        get
        {
            return this.shippingAddressField;
        }
        set
        {
            this.shippingAddressField = value;
        }
    }

    public long TotalQuantity
    {
        get
        {
            return this.totalQuantityField;
        }
        set
        {
            this.totalQuantityField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalQuantitySpecified
    {
        get
        {
            return this.totalQuantityFieldSpecified;
        }
        set
        {
            this.totalQuantityFieldSpecified = value;
        }
    }

    public bool ShippableAbroad
    {
        get
        {
            return this.shippableAbroadField;
        }
        set
        {
            this.shippableAbroadField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ShippableAbroadSpecified
    {
        get
        {
            return this.shippableAbroadFieldSpecified;
        }
        set
        {
            this.shippableAbroadFieldSpecified = value;
        }
    }

    public bool Combinable
    {
        get
        {
            return this.combinableField;
        }
        set
        {
            this.combinableField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CombinableSpecified
    {
        get
        {
            return this.combinableFieldSpecified;
        }
        set
        {
            this.combinableFieldSpecified = value;
        }
    }

    public bool OpenForUse
    {
        get
        {
            return this.openForUseField;
        }
        set
        {
            this.openForUseField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OpenForUseSpecified
    {
        get
        {
            return this.openForUseFieldSpecified;
        }
        set
        {
            this.openForUseFieldSpecified = value;
        }
    }

    public List<string> SpecialRequirements
    {
        get
        {
            return this.specialRequirementsField;
        }
        set
        {
            this.specialRequirementsField = value;
        }
    }

    public List<string> BasketMessages
    {
        get
        {
            return this.basketMessagesField;
        }
        set
        {
            this.basketMessagesField = value;
        }
    }

    public List<BasketItem> BasketItems
    {
        get
        {
            return this.basketItemsField;
        }
        set
        {
            this.basketItemsField = value;
        }
    }

    public List<PricingAdjustment> PricingAdjustments
    {
        get
        {
            return this.pricingAdjustmentsField;
        }
        set
        {
            this.pricingAdjustmentsField = value;
        }
    }
}

public partial class Address
{

    private string idField;

    private string genderField;

    private string firstNameField;

    private string lastNameField;

    private string infixField;

    private string companyNameField;

    private string cityField;

    private string countryField;

    private string countyField;

    private string houseNumberExtField;

    private string houseNumberField;

    private string postalCodeField;

    private string streetNameField;

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public string Gender
    {
        get
        {
            return this.genderField;
        }
        set
        {
            this.genderField = value;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }

    public string Infix
    {
        get
        {
            return this.infixField;
        }
        set
        {
            this.infixField = value;
        }
    }

    public string CompanyName
    {
        get
        {
            return this.companyNameField;
        }
        set
        {
            this.companyNameField = value;
        }
    }

    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    public string County
    {
        get
        {
            return this.countyField;
        }
        set
        {
            this.countyField = value;
        }
    }

    public string HouseNumberExt
    {
        get
        {
            return this.houseNumberExtField;
        }
        set
        {
            this.houseNumberExtField = value;
        }
    }

    public string HouseNumber
    {
        get
        {
            return this.houseNumberField;
        }
        set
        {
            this.houseNumberField = value;
        }
    }

    public string PostalCode
    {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }

    public string StreetName
    {
        get
        {
            return this.streetNameField;
        }
        set
        {
            this.streetNameField = value;
        }
    }
}

public partial class BasketItem
{

    private string idField;

    private double priceField;

    private bool priceFieldSpecified;

    private long quantityField;

    private bool quantityFieldSpecified;

    private string conditionField;

    private double listPriceField;

    private bool listPriceFieldSpecified;

    private string availabilityCodeField;

    private string availabilityDescriptionField;

    private string commentField;

    private bool secondHandField;

    private bool secondHandFieldSpecified;

    private Seller sellerField;

    private Product productField;

    public BasketItem()
    {
        this.productField = new Product();
        this.sellerField = new Seller();
    }

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public double Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PriceSpecified
    {
        get
        {
            return this.priceFieldSpecified;
        }
        set
        {
            this.priceFieldSpecified = value;
        }
    }

    public long Quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool QuantitySpecified
    {
        get
        {
            return this.quantityFieldSpecified;
        }
        set
        {
            this.quantityFieldSpecified = value;
        }
    }

    public string Condition
    {
        get
        {
            return this.conditionField;
        }
        set
        {
            this.conditionField = value;
        }
    }

    public double ListPrice
    {
        get
        {
            return this.listPriceField;
        }
        set
        {
            this.listPriceField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ListPriceSpecified
    {
        get
        {
            return this.listPriceFieldSpecified;
        }
        set
        {
            this.listPriceFieldSpecified = value;
        }
    }

    public string AvailabilityCode
    {
        get
        {
            return this.availabilityCodeField;
        }
        set
        {
            this.availabilityCodeField = value;
        }
    }

    public string AvailabilityDescription
    {
        get
        {
            return this.availabilityDescriptionField;
        }
        set
        {
            this.availabilityDescriptionField = value;
        }
    }

    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    public bool SecondHand
    {
        get
        {
            return this.secondHandField;
        }
        set
        {
            this.secondHandField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SecondHandSpecified
    {
        get
        {
            return this.secondHandFieldSpecified;
        }
        set
        {
            this.secondHandFieldSpecified = value;
        }
    }

    public Seller Seller
    {
        get
        {
            return this.sellerField;
        }
        set
        {
            this.sellerField = value;
        }
    }

    public Product Product
    {
        get
        {
            return this.productField;
        }
        set
        {
            this.productField = value;
        }
    }
}

public partial class PricingAdjustment
{

    private string descriptionField;

    private double amountField;

    private bool revocableField;

    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    public double Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    public bool Revocable
    {
        get
        {
            return this.revocableField;
        }
        set
        {
            this.revocableField = value;
        }
    }
}

public partial class Error
{

    private string codeField;

    private string messageField;

    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }
}

public partial class WishList
{

    private List<WishListItem> wishListItemsField;

    public WishList()
    {
        this.wishListItemsField = new List<WishListItem>();
    }

    public List<WishListItem> WishListItems
    {
        get
        {
            return this.wishListItemsField;
        }
        set
        {
            this.wishListItemsField = value;
        }
    }
}

public partial class WishListItem
{

    private string idField;

    private Product productField;

    public WishListItem()
    {
        this.productField = new Product();
    }

    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    public Product Product
    {
        get
        {
            return this.productField;
        }
        set
        {
            this.productField = value;
        }
    }
}

public partial class RelatedProducts
{

    private List<ProductFamily> productFamiliesField;

    private List<Accessory> accessoriesField;

    public RelatedProducts()
    {
        this.accessoriesField = new List<Accessory>();
        this.productFamiliesField = new List<ProductFamily>();
    }

    public List<ProductFamily> ProductFamilies
    {
        get
        {
            return this.productFamiliesField;
        }
        set
        {
            this.productFamiliesField = value;
        }
    }

    public List<Accessory> Accessories
    {
        get
        {
            return this.accessoriesField;
        }
        set
        {
            this.accessoriesField = value;
        }
    }
}

public partial class ProductFamily
{

    private string keyField;

    private string labelField;

    private List<ProductFamilyMember> productFamilyMembersField;

    public ProductFamily()
    {
        this.productFamilyMembersField = new List<ProductFamilyMember>();
    }

    public string Key
    {
        get
        {
            return this.keyField;
        }
        set
        {
            this.keyField = value;
        }
    }

    public string Label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    public List<ProductFamilyMember> ProductFamilyMembers
    {
        get
        {
            return this.productFamilyMembersField;
        }
        set
        {
            this.productFamilyMembersField = value;
        }
    }
}

public partial class ProductFamilyMember
{

    private string labelField;

    private string productIdField;

    public string Label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    public string productId
    {
        get
        {
            return this.productIdField;
        }
        set
        {
            this.productIdField = value;
        }
    }
}

public partial class Accessory
{

    private string productIdField;

    public string productId
    {
        get
        {
            return this.productIdField;
        }
        set
        {
            this.productIdField = value;
        }
    }
}

public partial class ParentCategoryPaths
{

    private List<ParentCategory> parentCategoriesField;

    public ParentCategoryPaths()
    {
        this.parentCategoriesField = new List<ParentCategory>();
    }

    public List<ParentCategory> ParentCategories
    {
        get
        {
            return this.parentCategoriesField;
        }
        set
        {
            this.parentCategoriesField = value;
        }
    }
}
