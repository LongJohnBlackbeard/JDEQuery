using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0523 - .
/// </summary>
public class F76B0523 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OFJOBS.
        /// </summary>
        public const string OFJOBS = "OFJOBS";

        /// <summary>
        /// OFINMG.
        /// </summary>
        public const string OFINMG = "OFINMG";

        /// <summary>
        /// OFDL01.
        /// </summary>
        public const string OFDL01 = "OFDL01";

        /// <summary>
        /// OFURCD.
        /// </summary>
        public const string OFURCD = "OFURCD";

        /// <summary>
        /// OFURDT.
        /// </summary>
        public const string OFURDT = "OFURDT";

        /// <summary>
        /// OFURAT.
        /// </summary>
        public const string OFURAT = "OFURAT";

        /// <summary>
        /// OFURAB.
        /// </summary>
        public const string OFURAB = "OFURAB";

        /// <summary>
        /// OFURRF.
        /// </summary>
        public const string OFURRF = "OFURRF";

        /// <summary>
        /// OFUSER.
        /// </summary>
        public const string OFUSER = "OFUSER";

        /// <summary>
        /// OFPID.
        /// </summary>
        public const string OFPID = "OFPID";

        /// <summary>
        /// OFJOBN.
        /// </summary>
        public const string OFJOBN = "OFJOBN";

        /// <summary>
        /// OFUPMJ.
        /// </summary>
        public const string OFUPMJ = "OFUPMJ";

        /// <summary>
        /// OFUPMT.
        /// </summary>
        public const string OFUPMT = "OFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0523";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OFJOBS", "OFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("OFINMG", "OFINMG", JdeDataType.String, 20, true, true),
        new JdeField("OFDL01", "OFDL01", JdeDataType.String, 60),
        new JdeField("OFURCD", "OFURCD", JdeDataType.String, 4),
        new JdeField("OFURDT", "OFURDT", JdeDataType.Numeric),
        new JdeField("OFURAT", "OFURAT", JdeDataType.Numeric),
        new JdeField("OFURAB", "OFURAB", JdeDataType.Numeric),
        new JdeField("OFURRF", "OFURRF", JdeDataType.String, 30),
        new JdeField("OFUSER", "OFUSER", JdeDataType.String, 20),
        new JdeField("OFPID", "OFPID", JdeDataType.String, 20),
        new JdeField("OFJOBN", "OFJOBN", JdeDataType.String, 20),
        new JdeField("OFUPMJ", "OFUPMJ", JdeDataType.Numeric),
        new JdeField("OFUPMT", "OFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0523_0", "Primary Key on OFJOBS, OFINMG", new[] { "OFJOBS", "OFINMG" }, isUnique: true, isPrimaryKey: true)
    };
}
