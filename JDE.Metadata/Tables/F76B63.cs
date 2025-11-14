using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B63 - .
/// </summary>
public class F76B63 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDCO.
        /// </summary>
        public const string BDCO = "BDCO";

        /// <summary>
        /// BDBRNCB.
        /// </summary>
        public const string BDBRNCB = "BDBRNCB";

        /// <summary>
        /// BDBRNBP.
        /// </summary>
        public const string BDBRNBP = "BDBRNBP";

        /// <summary>
        /// BDBRDIS.
        /// </summary>
        public const string BDBRDIS = "BDBRDIS";

        /// <summary>
        /// BDBRDID.
        /// </summary>
        public const string BDBRDID = "BDBRDID";

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
    public override string TableName => "F76B63";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDCO", "BDCO", JdeDataType.String, 10, true, true),
        new JdeField("BDBRNCB", "BDBRNCB", JdeDataType.String, 50, true, true),
        new JdeField("BDBRNBP", "BDBRNBP", JdeDataType.String, 50, true, true),
        new JdeField("BDBRDIS", "BDBRDIS", JdeDataType.Numeric),
        new JdeField("BDBRDID", "BDBRDID", JdeDataType.Numeric),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B63_0", "Primary Key on BDCO, BDBRNCB, BDBRNBP", new[] { "BDCO", "BDBRNCB", "BDBRNBP" }, isUnique: true, isPrimaryKey: true)
    };
}
