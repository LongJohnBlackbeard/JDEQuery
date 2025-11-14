using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H599 - .
/// </summary>
public class F44H599 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCWTMPT.
        /// </summary>
        public const string CMCWTMPT = "CMCWTMPT";

        /// <summary>
        /// CMHBMCUS.
        /// </summary>
        public const string CMHBMCUS = "CMHBMCUS";

        /// <summary>
        /// CMCLDATA.
        /// </summary>
        public const string CMCLDATA = "CMCLDATA";

        /// <summary>
        /// CMOPTYP.
        /// </summary>
        public const string CMOPTYP = "CMOPTYP";

        /// <summary>
        /// CMCLSRT.
        /// </summary>
        public const string CMCLSRT = "CMCLSRT";

        /// <summary>
        /// CMCRTU.
        /// </summary>
        public const string CMCRTU = "CMCRTU";

        /// <summary>
        /// CMCRTJ.
        /// </summary>
        public const string CMCRTJ = "CMCRTJ";

        /// <summary>
        /// CMCRTT.
        /// </summary>
        public const string CMCRTT = "CMCRTT";

        /// <summary>
        /// CMWRKSTNID.
        /// </summary>
        public const string CMWRKSTNID = "CMWRKSTNID";

        /// <summary>
        /// CMHBOPID.
        /// </summary>
        public const string CMHBOPID = "CMHBOPID";

        /// <summary>
        /// CMUPMB.
        /// </summary>
        public const string CMUPMB = "CMUPMB";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H599";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCWTMPT", "CMCWTMPT", JdeDataType.String, 24, true, true),
        new JdeField("CMHBMCUS", "CMHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("CMCLDATA", "CMCLDATA", JdeDataType.String, 20, true, true),
        new JdeField("CMOPTYP", "CMOPTYP", JdeDataType.String, 6, true, true),
        new JdeField("CMCLSRT", "CMCLSRT", JdeDataType.Numeric),
        new JdeField("CMCRTU", "CMCRTU", JdeDataType.String, 20),
        new JdeField("CMCRTJ", "CMCRTJ", JdeDataType.Numeric),
        new JdeField("CMCRTT", "CMCRTT", JdeDataType.Numeric),
        new JdeField("CMWRKSTNID", "CMWRKSTNID", JdeDataType.String, 20),
        new JdeField("CMHBOPID", "CMHBOPID", JdeDataType.String, 20),
        new JdeField("CMUPMB", "CMUPMB", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H599_0", "Primary Key on CMCWTMPT, CMHBMCUS, CMCLDATA, CMOPTYP", new[] { "CMCWTMPT", "CMHBMCUS", "CMCLDATA", "CMOPTYP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H599_2", "Index on CMCWTMPT, CMCLSRT, SYS_NC00016$", new[] { "CMCWTMPT", "CMCLSRT", "SYS_NC00016$" }),
        new JdeIndex("F44H599_3", "Index on CMCWTMPT, CMOPTYP, CMHBMCUS", new[] { "CMCWTMPT", "CMOPTYP", "CMHBMCUS" })
    };
}
