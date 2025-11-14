using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0105 - .
/// </summary>
public class F74U0105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIUKCCTY.
        /// </summary>
        public const string DIUKCCTY = "DIUKCCTY";

        /// <summary>
        /// DIUKRCD.
        /// </summary>
        public const string DIUKRCD = "DIUKRCD";

        /// <summary>
        /// DIUKCLASS.
        /// </summary>
        public const string DIUKCLASS = "DIUKCLASS";

        /// <summary>
        /// DIUKWHDC.
        /// </summary>
        public const string DIUKWHDC = "DIUKWHDC";

        /// <summary>
        /// DIUKCOMR.
        /// </summary>
        public const string DIUKCOMR = "DIUKCOMR";

        /// <summary>
        /// DIUKNINM.
        /// </summary>
        public const string DIUKNINM = "DIUKNINM";

        /// <summary>
        /// DIUKSTRD.
        /// </summary>
        public const string DIUKSTRD = "DIUKSTRD";

        /// <summary>
        /// DIUKEPRD.
        /// </summary>
        public const string DIUKEPRD = "DIUKEPRD";

        /// <summary>
        /// DIUKTRAS.
        /// </summary>
        public const string DIUKTRAS = "DIUKTRAS";

        /// <summary>
        /// DIUKATFR.
        /// </summary>
        public const string DIUKATFR = "DIUKATFR";

        /// <summary>
        /// DIUKVOCR.
        /// </summary>
        public const string DIUKVOCR = "DIUKVOCR";

        /// <summary>
        /// DIUKDOC1.
        /// </summary>
        public const string DIUKDOC1 = "DIUKDOC1";

        /// <summary>
        /// DIUKDOC2.
        /// </summary>
        public const string DIUKDOC2 = "DIUKDOC2";

        /// <summary>
        /// DIUKDOC3.
        /// </summary>
        public const string DIUKDOC3 = "DIUKDOC3";

        /// <summary>
        /// DIUKDOC4.
        /// </summary>
        public const string DIUKDOC4 = "DIUKDOC4";

        /// <summary>
        /// DIUKDOC5.
        /// </summary>
        public const string DIUKDOC5 = "DIUKDOC5";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIUKCCTY", "DIUKCCTY", JdeDataType.String, 20, true, true),
        new JdeField("DIUKRCD", "DIUKRCD", JdeDataType.String, 60),
        new JdeField("DIUKCLASS", "DIUKCLASS", JdeDataType.String, 2),
        new JdeField("DIUKWHDC", "DIUKWHDC", JdeDataType.String, 2),
        new JdeField("DIUKCOMR", "DIUKCOMR", JdeDataType.String, 2),
        new JdeField("DIUKNINM", "DIUKNINM", JdeDataType.String, 2),
        new JdeField("DIUKSTRD", "DIUKSTRD", JdeDataType.String, 2),
        new JdeField("DIUKEPRD", "DIUKEPRD", JdeDataType.String, 2),
        new JdeField("DIUKTRAS", "DIUKTRAS", JdeDataType.String, 2),
        new JdeField("DIUKATFR", "DIUKATFR", JdeDataType.String, 2),
        new JdeField("DIUKVOCR", "DIUKVOCR", JdeDataType.String, 2),
        new JdeField("DIUKDOC1", "DIUKDOC1", JdeDataType.String, 2),
        new JdeField("DIUKDOC2", "DIUKDOC2", JdeDataType.String, 2),
        new JdeField("DIUKDOC3", "DIUKDOC3", JdeDataType.String, 2),
        new JdeField("DIUKDOC4", "DIUKDOC4", JdeDataType.String, 2),
        new JdeField("DIUKDOC5", "DIUKDOC5", JdeDataType.String, 2),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0105_0", "Primary Key on DIUKCCTY", new[] { "DIUKCCTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0105_2", "Index on DIUKWHDC", new[] { "DIUKWHDC" }),
        new JdeIndex("F74U0105_3", "Index on DIUKVOCR", new[] { "DIUKVOCR" })
    };
}
