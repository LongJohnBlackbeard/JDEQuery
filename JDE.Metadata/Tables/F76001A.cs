using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76001A - .
/// </summary>
public class F76001A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCCO.
        /// </summary>
        public const string NCCO = "NCCO";

        /// <summary>
        /// NCADGI.
        /// </summary>
        public const string NCADGI = "NCADGI";

        /// <summary>
        /// NCACEM.
        /// </summary>
        public const string NCACEM = "NCACEM";

        /// <summary>
        /// NCARYO.
        /// </summary>
        public const string NCARYO = "NCARYO";

        /// <summary>
        /// NCSMAS.
        /// </summary>
        public const string NCSMAS = "NCSMAS";

        /// <summary>
        /// NCN001.
        /// </summary>
        public const string NCN001 = "NCN001";

        /// <summary>
        /// NCURCD.
        /// </summary>
        public const string NCURCD = "NCURCD";

        /// <summary>
        /// NCADGI1.
        /// </summary>
        public const string NCADGI1 = "NCADGI1";

        /// <summary>
        /// NCACEM1.
        /// </summary>
        public const string NCACEM1 = "NCACEM1";

        /// <summary>
        /// NCSMAS1.
        /// </summary>
        public const string NCSMAS1 = "NCSMAS1";
    }

    /// <inheritdoc />
    public override string TableName => "F76001A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCCO", "NCCO", JdeDataType.String, 10, true, true),
        new JdeField("NCADGI", "NCADGI", JdeDataType.String, 4, true, true),
        new JdeField("NCACEM", "NCACEM", JdeDataType.String, 8, true, true),
        new JdeField("NCARYO", "NCARYO", JdeDataType.String, 2, true, true),
        new JdeField("NCSMAS", "NCSMAS", JdeDataType.String, 4),
        new JdeField("NCN001", "NCN001", JdeDataType.Numeric),
        new JdeField("NCURCD", "NCURCD", JdeDataType.String, 4),
        new JdeField("NCADGI1", "NCADGI1", JdeDataType.String, 20, true, true),
        new JdeField("NCACEM1", "NCACEM1", JdeDataType.String, 30, true, true),
        new JdeField("NCSMAS1", "NCSMAS1", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76001A_0", "Primary Key on NCCO, NCADGI1, NCACEM1, NCARYO, NCADGI, NCACEM", new[] { "NCCO", "NCADGI1", "NCACEM1", "NCARYO", "NCADGI", "NCACEM" }, isUnique: true, isPrimaryKey: true)
    };
}
