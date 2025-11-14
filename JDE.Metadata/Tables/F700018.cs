using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700018 - .
/// </summary>
public class F700018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TEG70REPI.
        /// </summary>
        public const string TEG70REPI = "TEG70REPI";

        /// <summary>
        /// TEKCOO.
        /// </summary>
        public const string TEKCOO = "TEKCOO";

        /// <summary>
        /// TEDCTO.
        /// </summary>
        public const string TEDCTO = "TEDCTO";

        /// <summary>
        /// TEDOCO.
        /// </summary>
        public const string TEDOCO = "TEDOCO";

        /// <summary>
        /// TESFXO.
        /// </summary>
        public const string TESFXO = "TESFXO";

        /// <summary>
        /// TELNID.
        /// </summary>
        public const string TELNID = "TELNID";

        /// <summary>
        /// TEK74LECO.
        /// </summary>
        public const string TEK74LECO = "TEK74LECO";

        /// <summary>
        /// TEG70DTFR.
        /// </summary>
        public const string TEG70DTFR = "TEG70DTFR";

        /// <summary>
        /// TEG70DTTO.
        /// </summary>
        public const string TEG70DTTO = "TEG70DTTO";

        /// <summary>
        /// TEUSER.
        /// </summary>
        public const string TEUSER = "TEUSER";

        /// <summary>
        /// TEUPMJ.
        /// </summary>
        public const string TEUPMJ = "TEUPMJ";

        /// <summary>
        /// TEUPMT.
        /// </summary>
        public const string TEUPMT = "TEUPMT";

        /// <summary>
        /// TEJOBN.
        /// </summary>
        public const string TEJOBN = "TEJOBN";

        /// <summary>
        /// TEPID.
        /// </summary>
        public const string TEPID = "TEPID";
    }

    /// <inheritdoc />
    public override string TableName => "F700018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TEG70REPI", "TEG70REPI", JdeDataType.String, 20, true, true),
        new JdeField("TEKCOO", "TEKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TEDCTO", "TEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TEDOCO", "TEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TESFXO", "TESFXO", JdeDataType.String, 6, true, true),
        new JdeField("TELNID", "TELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TEK74LECO", "TEK74LECO", JdeDataType.String, 10),
        new JdeField("TEG70DTFR", "TEG70DTFR", JdeDataType.Numeric),
        new JdeField("TEG70DTTO", "TEG70DTTO", JdeDataType.Numeric),
        new JdeField("TEUSER", "TEUSER", JdeDataType.String, 20),
        new JdeField("TEUPMJ", "TEUPMJ", JdeDataType.Numeric),
        new JdeField("TEUPMT", "TEUPMT", JdeDataType.Numeric),
        new JdeField("TEJOBN", "TEJOBN", JdeDataType.String, 20),
        new JdeField("TEPID", "TEPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700018_0", "Primary Key on TEG70REPI, TEDCTO, TEDOCO, TESFXO, TELNID, TEKCOO", new[] { "TEG70REPI", "TEDCTO", "TEDOCO", "TESFXO", "TELNID", "TEKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
