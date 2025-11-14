using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76E4020 - .
/// </summary>
public class F76E4020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRDOCO.
        /// </summary>
        public const string CRDOCO = "CRDOCO";

        /// <summary>
        /// CRDCTO.
        /// </summary>
        public const string CRDCTO = "CRDCTO";

        /// <summary>
        /// CRAN8.
        /// </summary>
        public const string CRAN8 = "CRAN8";

        /// <summary>
        /// CRICU.
        /// </summary>
        public const string CRICU = "CRICU";

        /// <summary>
        /// CRTXA1.
        /// </summary>
        public const string CRTXA1 = "CRTXA1";

        /// <summary>
        /// CRE76RWNU.
        /// </summary>
        public const string CRE76RWNU = "CRE76RWNU";

        /// <summary>
        /// CRDL01.
        /// </summary>
        public const string CRDL01 = "CRDL01";

        /// <summary>
        /// CRDGJ.
        /// </summary>
        public const string CRDGJ = "CRDGJ";

        /// <summary>
        /// CRATXA.
        /// </summary>
        public const string CRATXA = "CRATXA";

        /// <summary>
        /// CRTXR1.
        /// </summary>
        public const string CRTXR1 = "CRTXR1";

        /// <summary>
        /// CRTXR3.
        /// </summary>
        public const string CRTXR3 = "CRTXR3";

        /// <summary>
        /// CRPAAP.
        /// </summary>
        public const string CRPAAP = "CRPAAP";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76E4020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRDOCO", "CRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CRDCTO", "CRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CRAN8", "CRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CRICU", "CRICU", JdeDataType.Numeric, null, true, true),
        new JdeField("CRTXA1", "CRTXA1", JdeDataType.String, 20, true, true),
        new JdeField("CRE76RWNU", "CRE76RWNU", JdeDataType.String, 8, true, true),
        new JdeField("CRDL01", "CRDL01", JdeDataType.String, 60),
        new JdeField("CRDGJ", "CRDGJ", JdeDataType.Numeric),
        new JdeField("CRATXA", "CRATXA", JdeDataType.Numeric),
        new JdeField("CRTXR1", "CRTXR1", JdeDataType.Numeric),
        new JdeField("CRTXR3", "CRTXR3", JdeDataType.Numeric),
        new JdeField("CRPAAP", "CRPAAP", JdeDataType.Numeric),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20, true, true),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20, true, true),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76E4020_0", "Primary Key on CRDOCO, CRDCTO, CRAN8, CRICU, CRTXA1, CRE76RWNU, CRUSER, CRJOBN", new[] { "CRDOCO", "CRDCTO", "CRAN8", "CRICU", "CRTXA1", "CRE76RWNU", "CRUSER", "CRJOBN" }, isUnique: true, isPrimaryKey: true)
    };
}
