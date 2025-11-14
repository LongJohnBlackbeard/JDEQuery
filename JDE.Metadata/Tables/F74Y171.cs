using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y171 - .
/// </summary>
public class F74Y171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRY74CTID.
        /// </summary>
        public const string CRY74CTID = "CRY74CTID";

        /// <summary>
        /// CRAN8.
        /// </summary>
        public const string CRAN8 = "CRAN8";

        /// <summary>
        /// CRKCO.
        /// </summary>
        public const string CRKCO = "CRKCO";

        /// <summary>
        /// CRDCT.
        /// </summary>
        public const string CRDCT = "CRDCT";

        /// <summary>
        /// CRDOC.
        /// </summary>
        public const string CRDOC = "CRDOC";

        /// <summary>
        /// CRSFX.
        /// </summary>
        public const string CRSFX = "CRSFX";

        /// <summary>
        /// CRSFXE.
        /// </summary>
        public const string CRSFXE = "CRSFXE";

        /// <summary>
        /// CRDGJ.
        /// </summary>
        public const string CRDGJ = "CRDGJ";

        /// <summary>
        /// CRAG.
        /// </summary>
        public const string CRAG = "CRAG";

        /// <summary>
        /// CRATXA.
        /// </summary>
        public const string CRATXA = "CRATXA";

        /// <summary>
        /// CRSTAM.
        /// </summary>
        public const string CRSTAM = "CRSTAM";

        /// <summary>
        /// CRTXR1.
        /// </summary>
        public const string CRTXR1 = "CRTXR1";

        /// <summary>
        /// CRTAX.
        /// </summary>
        public const string CRTAX = "CRTAX";

        /// <summary>
        /// CROKCO.
        /// </summary>
        public const string CROKCO = "CROKCO";

        /// <summary>
        /// CRODCT.
        /// </summary>
        public const string CRODCT = "CRODCT";

        /// <summary>
        /// CRODOC.
        /// </summary>
        public const string CRODOC = "CRODOC";

        /// <summary>
        /// CRVINV.
        /// </summary>
        public const string CRVINV = "CRVINV";

        /// <summary>
        /// CRY74PYM.
        /// </summary>
        public const string CRY74PYM = "CRY74PYM";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRY74CTID", "CRY74CTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRAN8", "CRAN8", JdeDataType.Numeric),
        new JdeField("CRKCO", "CRKCO", JdeDataType.String, 10, true, true),
        new JdeField("CRDCT", "CRDCT", JdeDataType.String, 4, true, true),
        new JdeField("CRDOC", "CRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CRSFX", "CRSFX", JdeDataType.String, 6, true, true),
        new JdeField("CRSFXE", "CRSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("CRDGJ", "CRDGJ", JdeDataType.Numeric),
        new JdeField("CRAG", "CRAG", JdeDataType.Numeric),
        new JdeField("CRATXA", "CRATXA", JdeDataType.Numeric),
        new JdeField("CRSTAM", "CRSTAM", JdeDataType.Numeric),
        new JdeField("CRTXR1", "CRTXR1", JdeDataType.Numeric),
        new JdeField("CRTAX", "CRTAX", JdeDataType.String, 40),
        new JdeField("CROKCO", "CROKCO", JdeDataType.String, 10),
        new JdeField("CRODCT", "CRODCT", JdeDataType.String, 4),
        new JdeField("CRODOC", "CRODOC", JdeDataType.Numeric),
        new JdeField("CRVINV", "CRVINV", JdeDataType.String, 50),
        new JdeField("CRY74PYM", "CRY74PYM", JdeDataType.Numeric),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y171_0", "Primary Key on CRY74CTID, CRKCO, CRDCT, CRDOC, CRSFX, CRSFXE", new[] { "CRY74CTID", "CRKCO", "CRDCT", "CRDOC", "CRSFX", "CRSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
