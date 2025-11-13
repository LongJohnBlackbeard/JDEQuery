using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101 - Item Master table metadata.
/// </summary>
public class F4101 : JdeTable
{
    /// <inheritdoc />
    public override string TableName => "F4101";

    /// <inheritdoc />
    public override string Description => "Item Master";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        // Primary Key
        new JdeField("IMITM", "Item Number - Short", JdeDataType.Numeric, null, true, true),

        // Item Description and Category
        new JdeField("IMDSC1", "Description", JdeDataType.String, 30),
        new JdeField("IMDSC2", "Description - Line 2", JdeDataType.String, 30),
        new JdeField("IMLITM", "2nd Item Number", JdeDataType.String, 25),
        new JdeField("IMAITM", "3rd Item Number", JdeDataType.String, 25),

        // Product Classifications
        new JdeField("IMSRP1", "Product Code - Major", JdeDataType.String, 3),
        new JdeField("IMSRP2", "Product Code - Minor", JdeDataType.String, 3),
        new JdeField("IMSRP3", "Product Code - Tier 3", JdeDataType.String, 3),
        new JdeField("IMSRP4", "Product Code - Tier 4", JdeDataType.String, 3),
        new JdeField("IMSRP5", "Product Code - Tier 5", JdeDataType.String, 3),

        // Item Characteristics
        new JdeField("IMSTKT", "Stocking Type", JdeDataType.String, 1),
        new JdeField("IMGLPT", "GL Category Code", JdeDataType.String, 4),
        new JdeField("IMUOM1", "Unit of Measure - Primary", JdeDataType.String, 2),
        new JdeField("IMUOM2", "Unit of Measure - Secondary", JdeDataType.String, 2),

        // Procurement and Cost
        new JdeField("IMPRP1", "Procurement Type", JdeDataType.String, 1),
        new JdeField("IMURCD", "Inventory Unit of Measure", JdeDataType.String, 2),
        new JdeField("IMURRF", "Unit of Measure - Reorder", JdeDataType.String, 2),

        // Status and Control
        new JdeField("IMSRP6", "Commodity Class - Major", JdeDataType.String, 3),
        new JdeField("IMSRP7", "Commodity Class - Minor", JdeDataType.String, 3),
        new JdeField("IMSRP8", "Commodity Class - Tier 3", JdeDataType.String, 3),
        new JdeField("IMSRP9", "Commodity Class - Tier 4", JdeDataType.String, 3),
        new JdeField("IMSRP0", "Commodity Class - Tier 5", JdeDataType.String, 3),

        // Planning and Availability
        new JdeField("IMLTLV", "Lead Time - Manufacturing", JdeDataType.Numeric, null),
        new JdeField("IMLTPU", "Lead Time - Cumulative", JdeDataType.Numeric, null),
        new JdeField("IMLNTY", "Lot Control", JdeDataType.String, 1),

        // Category Codes (User Defined)
        new JdeField("IMCRCD01", "Category Code 01", JdeDataType.String, 3),
        new JdeField("IMCRCD02", "Category Code 02", JdeDataType.String, 3),
        new JdeField("IMCRCD03", "Category Code 03", JdeDataType.String, 3),
        new JdeField("IMCRCD04", "Category Code 04", JdeDataType.String, 3),
        new JdeField("IMCRCD05", "Category Code 05", JdeDataType.String, 3),
        new JdeField("IMCRCD06", "Category Code 06", JdeDataType.String, 3),
        new JdeField("IMCRCD07", "Category Code 07", JdeDataType.String, 3),
        new JdeField("IMCRCD08", "Category Code 08", JdeDataType.String, 3),
        new JdeField("IMCRCD09", "Category Code 09", JdeDataType.String, 3),
        new JdeField("IMCRCD10", "Category Code 10", JdeDataType.String, 3),

        // Dates and Audit
        new JdeField("IMUPMJ", "Date - Updated", JdeDataType.Numeric, null), // Julian
        new JdeField("IMTDAY", "Time of Day", JdeDataType.Numeric, null),
        new JdeField("IMUSER", "User ID", JdeDataType.String, 10),
        new JdeField("IMPID", "Program ID", JdeDataType.String, 10),
        new JdeField("IMJOBN", "Work Station ID", JdeDataType.String, 10),
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        // Primary Key
        new JdeIndex("F4101_PK", "Primary Key - Item Number", new[] { "IMITM" }, isPrimaryKey: true),

        // Secondary Indexes
        new JdeIndex("F4101_1", "Index - 2nd Item Number", new[] { "IMLITM" }),
        new JdeIndex("F4101_2", "Index - 3rd Item Number", new[] { "IMAITM" }),
        new JdeIndex("F4101_3", "Index - Product Code", new[] { "IMSRP1", "IMSRP2" }),
        new JdeIndex("F4101_4", "Index - GL Category", new[] { "IMGLPT" }),
    };
}
