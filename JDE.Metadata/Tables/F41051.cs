using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41051 - .
/// </summary>
public class F41051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHITM.
        /// </summary>
        public const string CHITM = "CHITM";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHMMCU.
        /// </summary>
        public const string CHMMCU = "CHMMCU";

        /// <summary>
        /// CHLOCN.
        /// </summary>
        public const string CHLOCN = "CHLOCN";

        /// <summary>
        /// CHLOTN.
        /// </summary>
        public const string CHLOTN = "CHLOTN";

        /// <summary>
        /// CHTRQT.
        /// </summary>
        public const string CHTRQT = "CHTRQT";

        /// <summary>
        /// CHECST.
        /// </summary>
        public const string CHECST = "CHECST";

        /// <summary>
        /// CHCRCD.
        /// </summary>
        public const string CHCRCD = "CHCRCD";

        /// <summary>
        /// CHMGMN.
        /// </summary>
        public const string CHMGMN = "CHMGMN";

        /// <summary>
        /// CHUKID.
        /// </summary>
        public const string CHUKID = "CHUKID";

        /// <summary>
        /// CHPQOH.
        /// </summary>
        public const string CHPQOH = "CHPQOH";
    }

    /// <inheritdoc />
    public override string TableName => "F41051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHITM", "CHITM", JdeDataType.Numeric),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24),
        new JdeField("CHMMCU", "CHMMCU", JdeDataType.String, 24),
        new JdeField("CHLOCN", "CHLOCN", JdeDataType.String, 40),
        new JdeField("CHLOTN", "CHLOTN", JdeDataType.String, 60),
        new JdeField("CHTRQT", "CHTRQT", JdeDataType.Numeric),
        new JdeField("CHECST", "CHECST", JdeDataType.Numeric),
        new JdeField("CHCRCD", "CHCRCD", JdeDataType.String, 6),
        new JdeField("CHMGMN", "CHMGMN", JdeDataType.String, 2),
        new JdeField("CHUKID", "CHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHPQOH", "CHPQOH", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41051_0", "Primary Key on CHUKID", new[] { "CHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41051_2", "Index on CHITM, CHMCU, CHLOCN, CHLOTN", new[] { "CHITM", "CHMCU", "CHLOCN", "CHLOTN" })
    };
}
