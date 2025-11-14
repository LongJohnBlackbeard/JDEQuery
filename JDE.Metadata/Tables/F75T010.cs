using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T010 - .
/// </summary>
public class F75T010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UMMUSE.
        /// </summary>
        public const string UMMUSE = "UMMUSE";

        /// <summary>
        /// UM75TVTT.
        /// </summary>
        public const string UM75TVTT = "UM75TVTT";

        /// <summary>
        /// UMKCO.
        /// </summary>
        public const string UMKCO = "UMKCO";

        /// <summary>
        /// UM75TPSQ.
        /// </summary>
        public const string UM75TPSQ = "UM75TPSQ";

        /// <summary>
        /// UMCO.
        /// </summary>
        public const string UMCO = "UMCO";

        /// <summary>
        /// UM75TDSI.
        /// </summary>
        public const string UM75TDSI = "UM75TDSI";

        /// <summary>
        /// UM75TAUC.
        /// </summary>
        public const string UM75TAUC = "UM75TAUC";

        /// <summary>
        /// UM75TUMP.
        /// </summary>
        public const string UM75TUMP = "UM75TUMP";

        /// <summary>
        /// UMURC1.
        /// </summary>
        public const string UMURC1 = "UMURC1";

        /// <summary>
        /// UMURDT.
        /// </summary>
        public const string UMURDT = "UMURDT";

        /// <summary>
        /// UMURAT.
        /// </summary>
        public const string UMURAT = "UMURAT";

        /// <summary>
        /// UMURAB.
        /// </summary>
        public const string UMURAB = "UMURAB";

        /// <summary>
        /// UMURRF.
        /// </summary>
        public const string UMURRF = "UMURRF";

        /// <summary>
        /// UMUSER.
        /// </summary>
        public const string UMUSER = "UMUSER";

        /// <summary>
        /// UMPID.
        /// </summary>
        public const string UMPID = "UMPID";

        /// <summary>
        /// UMJOBN.
        /// </summary>
        public const string UMJOBN = "UMJOBN";

        /// <summary>
        /// UMUPMJ.
        /// </summary>
        public const string UMUPMJ = "UMUPMJ";

        /// <summary>
        /// UMTDAY.
        /// </summary>
        public const string UMTDAY = "UMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UMMUSE", "UMMUSE", JdeDataType.String, 20, true, true),
        new JdeField("UM75TVTT", "UM75TVTT", JdeDataType.String, 6, true, true),
        new JdeField("UMKCO", "UMKCO", JdeDataType.String, 10, true, true),
        new JdeField("UM75TPSQ", "UM75TPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("UMCO", "UMCO", JdeDataType.String, 10),
        new JdeField("UM75TDSI", "UM75TDSI", JdeDataType.String, 10),
        new JdeField("UM75TAUC", "UM75TAUC", JdeDataType.String, 20),
        new JdeField("UM75TUMP", "UM75TUMP", JdeDataType.String, 2),
        new JdeField("UMURC1", "UMURC1", JdeDataType.String, 6),
        new JdeField("UMURDT", "UMURDT", JdeDataType.Numeric),
        new JdeField("UMURAT", "UMURAT", JdeDataType.Numeric),
        new JdeField("UMURAB", "UMURAB", JdeDataType.Numeric),
        new JdeField("UMURRF", "UMURRF", JdeDataType.String, 30),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMJOBN", "UMJOBN", JdeDataType.String, 20),
        new JdeField("UMUPMJ", "UMUPMJ", JdeDataType.Numeric),
        new JdeField("UMTDAY", "UMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T010_0", "Primary Key on UMMUSE, UM75TVTT, UMKCO, UM75TPSQ", new[] { "UMMUSE", "UM75TVTT", "UMKCO", "UM75TPSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T010_2", "Index on UMCO, UM75TDSI", new[] { "UMCO", "UM75TDSI" })
    };
}
