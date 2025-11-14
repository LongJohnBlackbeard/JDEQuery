using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B474 - .
/// </summary>
public class F76B474 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BABKCD.
        /// </summary>
        public const string BABKCD = "BABKCD";

        /// <summary>
        /// BATYTN.
        /// </summary>
        public const string BATYTN = "BATYTN";

        /// <summary>
        /// BADRIN.
        /// </summary>
        public const string BADRIN = "BADRIN";

        /// <summary>
        /// BAPTH.
        /// </summary>
        public const string BAPTH = "BAPTH";

        /// <summary>
        /// BAFEXT.
        /// </summary>
        public const string BAFEXT = "BAFEXT";

        /// <summary>
        /// BABDFLAY.
        /// </summary>
        public const string BABDFLAY = "BABDFLAY";

        /// <summary>
        /// BAEDTY.
        /// </summary>
        public const string BAEDTY = "BAEDTY";

        /// <summary>
        /// BAPID.
        /// </summary>
        public const string BAPID = "BAPID";

        /// <summary>
        /// BAJOBN.
        /// </summary>
        public const string BAJOBN = "BAJOBN";

        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAUPMJ.
        /// </summary>
        public const string BAUPMJ = "BAUPMJ";

        /// <summary>
        /// BAUPMT.
        /// </summary>
        public const string BAUPMT = "BAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B474";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BABKCD", "BABKCD", JdeDataType.String, 6, true, true),
        new JdeField("BATYTN", "BATYTN", JdeDataType.String, 16, true, true),
        new JdeField("BADRIN", "BADRIN", JdeDataType.String, 2, true, true),
        new JdeField("BAPTH", "BAPTH", JdeDataType.String, 240),
        new JdeField("BAFEXT", "BAFEXT", JdeDataType.String, 6),
        new JdeField("BABDFLAY", "BABDFLAY", JdeDataType.String, 20),
        new JdeField("BAEDTY", "BAEDTY", JdeDataType.String, 2),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric),
        new JdeField("BAUPMT", "BAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B474_0", "Primary Key on BABKCD, BATYTN, BADRIN", new[] { "BABKCD", "BATYTN", "BADRIN" }, isUnique: true, isPrimaryKey: true)
    };
}
