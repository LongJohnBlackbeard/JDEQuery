using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U071T - .
/// </summary>
public class F74U071T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDMCU.
        /// </summary>
        public const string PDMCU = "PDMCU";

        /// <summary>
        /// PDUNIT.
        /// </summary>
        public const string PDUNIT = "PDUNIT";

        /// <summary>
        /// PD74UTRB.
        /// </summary>
        public const string PD74UTRB = "PD74UTRB";

        /// <summary>
        /// PD74UTCB.
        /// </summary>
        public const string PD74UTCB = "PD74UTCB";

        /// <summary>
        /// PD74UPMIX.
        /// </summary>
        public const string PD74UPMIX = "PD74UPMIX";

        /// <summary>
        /// PD74UFXR.
        /// </summary>
        public const string PD74UFXR = "PD74UFXR";

        /// <summary>
        /// PD74UTRE.
        /// </summary>
        public const string PD74UTRE = "PD74UTRE";

        /// <summary>
        /// PD74UTCE.
        /// </summary>
        public const string PD74UTCE = "PD74UTCE";

        /// <summary>
        /// PD74UUC.
        /// </summary>
        public const string PD74UUC = "PD74UUC";

        /// <summary>
        /// PD74UEFTB.
        /// </summary>
        public const string PD74UEFTB = "PD74UEFTB";

        /// <summary>
        /// PD74UEFTE.
        /// </summary>
        public const string PD74UEFTE = "PD74UEFTE";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U071T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDMCU", "PDMCU", JdeDataType.String, 24, true, true),
        new JdeField("PDUNIT", "PDUNIT", JdeDataType.String, 16, true, true),
        new JdeField("PD74UTRB", "PD74UTRB", JdeDataType.String, 20),
        new JdeField("PD74UTCB", "PD74UTCB", JdeDataType.String, 4),
        new JdeField("PD74UPMIX", "PD74UPMIX", JdeDataType.String, 2),
        new JdeField("PD74UFXR", "PD74UFXR", JdeDataType.String, 20),
        new JdeField("PD74UTRE", "PD74UTRE", JdeDataType.String, 20),
        new JdeField("PD74UTCE", "PD74UTCE", JdeDataType.String, 4),
        new JdeField("PD74UUC", "PD74UUC", JdeDataType.Numeric),
        new JdeField("PD74UEFTB", "PD74UEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("PD74UEFTE", "PD74UEFTE", JdeDataType.Numeric),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U071T_0", "Primary Key on PDMCU, PDUNIT, PD74UEFTB", new[] { "PDMCU", "PDUNIT", "PD74UEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
