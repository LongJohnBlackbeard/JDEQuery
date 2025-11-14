using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96410 - .
/// </summary>
public class F96410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRITEM1.
        /// </summary>
        public const string SRITEM1 = "SRITEM1";

        /// <summary>
        /// SRVERS1.
        /// </summary>
        public const string SRVERS1 = "SRVERS1";

        /// <summary>
        /// SRITEMTYPE1.
        /// </summary>
        public const string SRITEMTYPE1 = "SRITEMTYPE1";

        /// <summary>
        /// SRITEM2.
        /// </summary>
        public const string SRITEM2 = "SRITEM2";

        /// <summary>
        /// SRVERS2.
        /// </summary>
        public const string SRVERS2 = "SRVERS2";

        /// <summary>
        /// SRITEMTYPE2.
        /// </summary>
        public const string SRITEMTYPE2 = "SRITEMTYPE2";

        /// <summary>
        /// SRRULETYPE.
        /// </summary>
        public const string SRRULETYPE = "SRRULETYPE";

        /// <summary>
        /// SRLL.
        /// </summary>
        public const string SRLL = "SRLL";

        /// <summary>
        /// SRRULEPR.
        /// </summary>
        public const string SRRULEPR = "SRRULEPR";

        /// <summary>
        /// SRFUTUSE02.
        /// </summary>
        public const string SRFUTUSE02 = "SRFUTUSE02";

        /// <summary>
        /// SRFUTUSE03.
        /// </summary>
        public const string SRFUTUSE03 = "SRFUTUSE03";

        /// <summary>
        /// SRFUTUSE010.
        /// </summary>
        public const string SRFUTUSE010 = "SRFUTUSE010";

        /// <summary>
        /// SRFUTUSE011.
        /// </summary>
        public const string SRFUTUSE011 = "SRFUTUSE011";

        /// <summary>
        /// SRFUTUSE22.
        /// </summary>
        public const string SRFUTUSE22 = "SRFUTUSE22";

        /// <summary>
        /// SRFUTUSE23.
        /// </summary>
        public const string SRFUTUSE23 = "SRFUTUSE23";

        /// <summary>
        /// SRFUTDATE1.
        /// </summary>
        public const string SRFUTDATE1 = "SRFUTDATE1";

        /// <summary>
        /// SRSUFUUPMT.
        /// </summary>
        public const string SRSUFUUPMT = "SRSUFUUPMT";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRJOBN.
        /// </summary>
        public const string SRJOBN = "SRJOBN";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRUPMT.
        /// </summary>
        public const string SRUPMT = "SRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRITEM1", "SRITEM1", JdeDataType.String, 20, true, true),
        new JdeField("SRVERS1", "SRVERS1", JdeDataType.String, 20, true, true),
        new JdeField("SRITEMTYPE1", "SRITEMTYPE1", JdeDataType.String, 4, true, true),
        new JdeField("SRITEM2", "SRITEM2", JdeDataType.String, 20, true, true),
        new JdeField("SRVERS2", "SRVERS2", JdeDataType.String, 20, true, true),
        new JdeField("SRITEMTYPE2", "SRITEMTYPE2", JdeDataType.String, 4, true, true),
        new JdeField("SRRULETYPE", "SRRULETYPE", JdeDataType.String, 4, true, true),
        new JdeField("SRLL", "SRLL", JdeDataType.String, 20),
        new JdeField("SRRULEPR", "SRRULEPR", JdeDataType.Numeric),
        new JdeField("SRFUTUSE02", "SRFUTUSE02", JdeDataType.String, 20),
        new JdeField("SRFUTUSE03", "SRFUTUSE03", JdeDataType.String, 40),
        new JdeField("SRFUTUSE010", "SRFUTUSE010", JdeDataType.Numeric),
        new JdeField("SRFUTUSE011", "SRFUTUSE011", JdeDataType.Numeric),
        new JdeField("SRFUTUSE22", "SRFUTUSE22", JdeDataType.String, 2),
        new JdeField("SRFUTUSE23", "SRFUTUSE23", JdeDataType.String, 2),
        new JdeField("SRFUTDATE1", "SRFUTDATE1", JdeDataType.Numeric),
        new JdeField("SRSUFUUPMT", "SRSUFUUPMT", JdeDataType.Numeric),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRJOBN", "SRJOBN", JdeDataType.String, 20),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRUPMT", "SRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96410_0", "Primary Key on SRITEM1, SRVERS1, SRITEMTYPE1, SRITEM2, SRVERS2, SRITEMTYPE2, SRRULETYPE", new[] { "SRITEM1", "SRVERS1", "SRITEMTYPE1", "SRITEM2", "SRVERS2", "SRITEMTYPE2", "SRRULETYPE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F96410_2", "Index on SRRULETYPE", new[] { "SRRULETYPE" }),
        new JdeIndex("F96410_3", "Index on SRITEM1, SRITEM2, SRVERS1, SRVERS2", new[] { "SRITEM1", "SRITEM2", "SRVERS1", "SRVERS2" })
    };
}
