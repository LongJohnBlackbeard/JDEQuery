using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4906 - .
/// </summary>
public class F4906 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCARS.
        /// </summary>
        public const string CMCARS = "CMCARS";

        /// <summary>
        /// CMSCAC.
        /// </summary>
        public const string CMSCAC = "CMSCAC";

        /// <summary>
        /// CMCAMD.
        /// </summary>
        public const string CMCAMD = "CMCAMD";

        /// <summary>
        /// CMSTBF.
        /// </summary>
        public const string CMSTBF = "CMSTBF";

        /// <summary>
        /// CMSTFT.
        /// </summary>
        public const string CMSTFT = "CMSTFT";

        /// <summary>
        /// CMRFQ1.
        /// </summary>
        public const string CMRFQ1 = "CMRFQ1";

        /// <summary>
        /// CMRFQ2.
        /// </summary>
        public const string CMRFQ2 = "CMRFQ2";

        /// <summary>
        /// CMRNDN.
        /// </summary>
        public const string CMRNDN = "CMRNDN";

        /// <summary>
        /// CMDWFC.
        /// </summary>
        public const string CMDWFC = "CMDWFC";

        /// <summary>
        /// CMRSLA.
        /// </summary>
        public const string CMRSLA = "CMRSLA";

        /// <summary>
        /// CMPFSD.
        /// </summary>
        public const string CMPFSD = "CMPFSD";

        /// <summary>
        /// CMPRFM.
        /// </summary>
        public const string CMPRFM = "CMPRFM";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMTDAY.
        /// </summary>
        public const string CMTDAY = "CMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4906";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCARS", "CMCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("CMSCAC", "CMSCAC", JdeDataType.String, 8),
        new JdeField("CMCAMD", "CMCAMD", JdeDataType.String, 2),
        new JdeField("CMSTBF", "CMSTBF", JdeDataType.String, 64),
        new JdeField("CMSTFT", "CMSTFT", JdeDataType.String, 6),
        new JdeField("CMRFQ1", "CMRFQ1", JdeDataType.String, 4),
        new JdeField("CMRFQ2", "CMRFQ2", JdeDataType.String, 4),
        new JdeField("CMRNDN", "CMRNDN", JdeDataType.String, 2),
        new JdeField("CMDWFC", "CMDWFC", JdeDataType.Numeric),
        new JdeField("CMRSLA", "CMRSLA", JdeDataType.String, 2),
        new JdeField("CMPFSD", "CMPFSD", JdeDataType.String, 2),
        new JdeField("CMPRFM", "CMPRFM", JdeDataType.Numeric),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMTDAY", "CMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4906_0", "Primary Key on CMCARS", new[] { "CMCARS" }, isUnique: true, isPrimaryKey: true)
    };
}
