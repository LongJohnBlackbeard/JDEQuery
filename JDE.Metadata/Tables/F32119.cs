using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32119 - .
/// </summary>
public class F32119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KSCFGID.
        /// </summary>
        public const string KSCFGID = "KSCFGID";

        /// <summary>
        /// KSCFGCID.
        /// </summary>
        public const string KSCFGCID = "KSCFGCID";

        /// <summary>
        /// KSPEL.
        /// </summary>
        public const string KSPEL = "KSPEL";

        /// <summary>
        /// KSSGVL.
        /// </summary>
        public const string KSSGVL = "KSSGVL";

        /// <summary>
        /// KSKIT.
        /// </summary>
        public const string KSKIT = "KSKIT";

        /// <summary>
        /// KSCFGSID.
        /// </summary>
        public const string KSCFGSID = "KSCFGSID";

        /// <summary>
        /// KSATSA.
        /// </summary>
        public const string KSATSA = "KSATSA";

        /// <summary>
        /// KSCNUM.
        /// </summary>
        public const string KSCNUM = "KSCNUM";

        /// <summary>
        /// KSURCD.
        /// </summary>
        public const string KSURCD = "KSURCD";

        /// <summary>
        /// KSURDT.
        /// </summary>
        public const string KSURDT = "KSURDT";

        /// <summary>
        /// KSURAT.
        /// </summary>
        public const string KSURAT = "KSURAT";

        /// <summary>
        /// KSURAB.
        /// </summary>
        public const string KSURAB = "KSURAB";

        /// <summary>
        /// KSURRF.
        /// </summary>
        public const string KSURRF = "KSURRF";

        /// <summary>
        /// KSUSER.
        /// </summary>
        public const string KSUSER = "KSUSER";

        /// <summary>
        /// KSPID.
        /// </summary>
        public const string KSPID = "KSPID";

        /// <summary>
        /// KSJOBN.
        /// </summary>
        public const string KSJOBN = "KSJOBN";

        /// <summary>
        /// KSUPMJ.
        /// </summary>
        public const string KSUPMJ = "KSUPMJ";

        /// <summary>
        /// KSTDAY.
        /// </summary>
        public const string KSTDAY = "KSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KSCFGID", "KSCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("KSCFGCID", "KSCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("KSPEL", "KSPEL", JdeDataType.Numeric, null, true, true),
        new JdeField("KSSGVL", "KSSGVL", JdeDataType.String, 80, true, true),
        new JdeField("KSKIT", "KSKIT", JdeDataType.Numeric),
        new JdeField("KSCFGSID", "KSCFGSID", JdeDataType.String, 64),
        new JdeField("KSATSA", "KSATSA", JdeDataType.String, 2),
        new JdeField("KSCNUM", "KSCNUM", JdeDataType.String, 2),
        new JdeField("KSURCD", "KSURCD", JdeDataType.String, 4),
        new JdeField("KSURDT", "KSURDT", JdeDataType.Numeric),
        new JdeField("KSURAT", "KSURAT", JdeDataType.Numeric),
        new JdeField("KSURAB", "KSURAB", JdeDataType.Numeric),
        new JdeField("KSURRF", "KSURRF", JdeDataType.String, 30),
        new JdeField("KSUSER", "KSUSER", JdeDataType.String, 20),
        new JdeField("KSPID", "KSPID", JdeDataType.String, 20),
        new JdeField("KSJOBN", "KSJOBN", JdeDataType.String, 20),
        new JdeField("KSUPMJ", "KSUPMJ", JdeDataType.Numeric),
        new JdeField("KSTDAY", "KSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32119_0", "Primary Key on KSCFGID, KSCFGCID, KSPEL, KSSGVL", new[] { "KSCFGID", "KSCFGCID", "KSPEL", "KSSGVL" }, isUnique: true, isPrimaryKey: true)
    };
}
