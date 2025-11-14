using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0450 - .
/// </summary>
public class F74U0450 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPUKCCTY.
        /// </summary>
        public const string SPUKCCTY = "SPUKCCTY";

        /// <summary>
        /// SPUKSPT.
        /// </summary>
        public const string SPUKSPT = "SPUKSPT";

        /// <summary>
        /// SPUKCCDY.
        /// </summary>
        public const string SPUKCCDY = "SPUKCCDY";

        /// <summary>
        /// SPUKSPYE.
        /// </summary>
        public const string SPUKSPYE = "SPUKSPYE";

        /// <summary>
        /// SPUKPMT.
        /// </summary>
        public const string SPUKPMT = "SPUKPMT";

        /// <summary>
        /// SPUKTXD.
        /// </summary>
        public const string SPUKTXD = "SPUKTXD";

        /// <summary>
        /// SPUKSPD.
        /// </summary>
        public const string SPUKSPD = "SPUKSPD";

        /// <summary>
        /// SPUKCIS25.
        /// </summary>
        public const string SPUKCIS25 = "SPUKCIS25";

        /// <summary>
        /// SPUKCIS23.
        /// </summary>
        public const string SPUKCIS23 = "SPUKCIS23";

        /// <summary>
        /// SPUKCIS24.
        /// </summary>
        public const string SPUKCIS24 = "SPUKCIS24";

        /// <summary>
        /// SPUKSPCAT1.
        /// </summary>
        public const string SPUKSPCAT1 = "SPUKSPCAT1";

        /// <summary>
        /// SPUKSPCAT2.
        /// </summary>
        public const string SPUKSPCAT2 = "SPUKSPCAT2";

        /// <summary>
        /// SPUKSPCAT3.
        /// </summary>
        public const string SPUKSPCAT3 = "SPUKSPCAT3";

        /// <summary>
        /// SPUKSPCAT4.
        /// </summary>
        public const string SPUKSPCAT4 = "SPUKSPCAT4";

        /// <summary>
        /// SPUKSPCAT5.
        /// </summary>
        public const string SPUKSPCAT5 = "SPUKSPCAT5";

        /// <summary>
        /// SPURCD.
        /// </summary>
        public const string SPURCD = "SPURCD";

        /// <summary>
        /// SPURAB.
        /// </summary>
        public const string SPURAB = "SPURAB";

        /// <summary>
        /// SPURAT.
        /// </summary>
        public const string SPURAT = "SPURAT";

        /// <summary>
        /// SPURDT.
        /// </summary>
        public const string SPURDT = "SPURDT";

        /// <summary>
        /// SPURRF.
        /// </summary>
        public const string SPURRF = "SPURRF";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";

        /// <summary>
        /// SPUPMT.
        /// </summary>
        public const string SPUPMT = "SPUPMT";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0450";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPUKCCTY", "SPUKCCTY", JdeDataType.String, 20, true, true),
        new JdeField("SPUKSPT", "SPUKSPT", JdeDataType.String, 2, true, true),
        new JdeField("SPUKCCDY", "SPUKCCDY", JdeDataType.String, 20, true, true),
        new JdeField("SPUKSPYE", "SPUKSPYE", JdeDataType.String, 60),
        new JdeField("SPUKPMT", "SPUKPMT", JdeDataType.String, 2),
        new JdeField("SPUKTXD", "SPUKTXD", JdeDataType.String, 2),
        new JdeField("SPUKSPD", "SPUKSPD", JdeDataType.String, 2),
        new JdeField("SPUKCIS25", "SPUKCIS25", JdeDataType.String, 2),
        new JdeField("SPUKCIS23", "SPUKCIS23", JdeDataType.String, 2),
        new JdeField("SPUKCIS24", "SPUKCIS24", JdeDataType.String, 2),
        new JdeField("SPUKSPCAT1", "SPUKSPCAT1", JdeDataType.String, 6),
        new JdeField("SPUKSPCAT2", "SPUKSPCAT2", JdeDataType.String, 6),
        new JdeField("SPUKSPCAT3", "SPUKSPCAT3", JdeDataType.String, 20),
        new JdeField("SPUKSPCAT4", "SPUKSPCAT4", JdeDataType.String, 20),
        new JdeField("SPUKSPCAT5", "SPUKSPCAT5", JdeDataType.String, 20),
        new JdeField("SPURCD", "SPURCD", JdeDataType.String, 4),
        new JdeField("SPURAB", "SPURAB", JdeDataType.Numeric),
        new JdeField("SPURAT", "SPURAT", JdeDataType.Numeric),
        new JdeField("SPURDT", "SPURDT", JdeDataType.Numeric),
        new JdeField("SPURRF", "SPURRF", JdeDataType.String, 30),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUPMT", "SPUPMT", JdeDataType.Numeric),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0450_0", "Primary Key on SPUKCCTY, SPUKSPT, SPUKCCDY", new[] { "SPUKCCTY", "SPUKSPT", "SPUKCCDY" }, isUnique: true, isPrimaryKey: true)
    };
}
