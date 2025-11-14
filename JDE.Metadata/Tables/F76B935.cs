using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B935 - .
/// </summary>
public class F76B935 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDB76SBON.
        /// </summary>
        public const string BDB76SBON = "BDB76SBON";

        /// <summary>
        /// BDB76SBPU.
        /// </summary>
        public const string BDB76SBPU = "BDB76SBPU";

        /// <summary>
        /// BDAID.
        /// </summary>
        public const string BDAID = "BDAID";

        /// <summary>
        /// BDANI.
        /// </summary>
        public const string BDANI = "BDANI";

        /// <summary>
        /// BDB76BOTY.
        /// </summary>
        public const string BDB76BOTY = "BDB76BOTY";

        /// <summary>
        /// BDB76BTBA.
        /// </summary>
        public const string BDB76BTBA = "BDB76BTBA";

        /// <summary>
        /// BDB76BEXT.
        /// </summary>
        public const string BDB76BEXT = "BDB76BEXT";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B935";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDB76SBON", "BDB76SBON", JdeDataType.Numeric, null, true, true),
        new JdeField("BDB76SBPU", "BDB76SBPU", JdeDataType.String, 160),
        new JdeField("BDAID", "BDAID", JdeDataType.String, 16),
        new JdeField("BDANI", "BDANI", JdeDataType.String, 58),
        new JdeField("BDB76BOTY", "BDB76BOTY", JdeDataType.String, 2),
        new JdeField("BDB76BTBA", "BDB76BTBA", JdeDataType.Numeric),
        new JdeField("BDB76BEXT", "BDB76BEXT", JdeDataType.String, 2),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B935_0", "Primary Key on BDB76SBON", new[] { "BDB76SBON" }, isUnique: true, isPrimaryKey: true)
    };
}
