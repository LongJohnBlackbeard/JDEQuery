using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3295 - .
/// </summary>
public class F3295 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KSKIT.
        /// </summary>
        public const string KSKIT = "KSKIT";

        /// <summary>
        /// KSMCU.
        /// </summary>
        public const string KSMCU = "KSMCU";

        /// <summary>
        /// KSPEL.
        /// </summary>
        public const string KSPEL = "KSPEL";

        /// <summary>
        /// KSDSC1.
        /// </summary>
        public const string KSDSC1 = "KSDSC1";

        /// <summary>
        /// KSVL01.
        /// </summary>
        public const string KSVL01 = "KSVL01";

        /// <summary>
        /// KSDOCO.
        /// </summary>
        public const string KSDOCO = "KSDOCO";

        /// <summary>
        /// KSDCTO.
        /// </summary>
        public const string KSDCTO = "KSDCTO";

        /// <summary>
        /// KSKCOO.
        /// </summary>
        public const string KSKCOO = "KSKCOO";

        /// <summary>
        /// KSLNID.
        /// </summary>
        public const string KSLNID = "KSLNID";

        /// <summary>
        /// KSITM.
        /// </summary>
        public const string KSITM = "KSITM";

        /// <summary>
        /// KSCMCU.
        /// </summary>
        public const string KSCMCU = "KSCMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F3295";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KSKIT", "KSKIT", JdeDataType.Numeric),
        new JdeField("KSMCU", "KSMCU", JdeDataType.String, 24),
        new JdeField("KSPEL", "KSPEL", JdeDataType.Numeric, null, true, true),
        new JdeField("KSDSC1", "KSDSC1", JdeDataType.String, 60),
        new JdeField("KSVL01", "KSVL01", JdeDataType.String, 50),
        new JdeField("KSDOCO", "KSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("KSDCTO", "KSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("KSKCOO", "KSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("KSLNID", "KSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("KSITM", "KSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("KSCMCU", "KSCMCU", JdeDataType.String, 24, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3295_0", "Primary Key on KSDOCO, KSDCTO, KSKCOO, KSLNID, KSITM, KSCMCU, KSPEL", new[] { "KSDOCO", "KSDCTO", "KSKCOO", "KSLNID", "KSITM", "KSCMCU", "KSPEL" }, isUnique: true, isPrimaryKey: true)
    };
}
