using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F054115W - .
/// </summary>
public class F054115W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PNAN8.
        /// </summary>
        public const string PNAN8 = "PNAN8";

        /// <summary>
        /// PNIDLN.
        /// </summary>
        public const string PNIDLN = "PNIDLN";

        /// <summary>
        /// PNRCK7.
        /// </summary>
        public const string PNRCK7 = "PNRCK7";

        /// <summary>
        /// PNAR1.
        /// </summary>
        public const string PNAR1 = "PNAR1";

        /// <summary>
        /// PNPH1.
        /// </summary>
        public const string PNPH1 = "PNPH1";

        /// <summary>
        /// PNPHTP.
        /// </summary>
        public const string PNPHTP = "PNPHTP";

        /// <summary>
        /// PNACFL.
        /// </summary>
        public const string PNACFL = "PNACFL";

        /// <summary>
        /// PNUSER.
        /// </summary>
        public const string PNUSER = "PNUSER";

        /// <summary>
        /// PNPID.
        /// </summary>
        public const string PNPID = "PNPID";

        /// <summary>
        /// PNJOBN.
        /// </summary>
        public const string PNJOBN = "PNJOBN";

        /// <summary>
        /// PNUPMJ.
        /// </summary>
        public const string PNUPMJ = "PNUPMJ";

        /// <summary>
        /// PNUPMT.
        /// </summary>
        public const string PNUPMT = "PNUPMT";

        /// <summary>
        /// PNESIGN.
        /// </summary>
        public const string PNESIGN = "PNESIGN";

        /// <summary>
        /// PNMUMJ.
        /// </summary>
        public const string PNMUMJ = "PNMUMJ";

        /// <summary>
        /// PNMUMT.
        /// </summary>
        public const string PNMUMT = "PNMUMT";

        /// <summary>
        /// PNUPID.
        /// </summary>
        public const string PNUPID = "PNUPID";
    }

    /// <inheritdoc />
    public override string TableName => "F054115W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PNAN8", "PNAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PNIDLN", "PNIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PNRCK7", "PNRCK7", JdeDataType.Numeric, null, true, true),
        new JdeField("PNAR1", "PNAR1", JdeDataType.String, 12),
        new JdeField("PNPH1", "PNPH1", JdeDataType.String, 40),
        new JdeField("PNPHTP", "PNPHTP", JdeDataType.String, 8),
        new JdeField("PNACFL", "PNACFL", JdeDataType.String, 2),
        new JdeField("PNUSER", "PNUSER", JdeDataType.String, 20),
        new JdeField("PNPID", "PNPID", JdeDataType.String, 20),
        new JdeField("PNJOBN", "PNJOBN", JdeDataType.String, 20),
        new JdeField("PNUPMJ", "PNUPMJ", JdeDataType.Numeric),
        new JdeField("PNUPMT", "PNUPMT", JdeDataType.Numeric),
        new JdeField("PNESIGN", "PNESIGN", JdeDataType.String, 32),
        new JdeField("PNMUMJ", "PNMUMJ", JdeDataType.Numeric),
        new JdeField("PNMUMT", "PNMUMT", JdeDataType.Numeric),
        new JdeField("PNUPID", "PNUPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F054115W_0", "Primary Key on PNAN8, PNIDLN, PNRCK7", new[] { "PNAN8", "PNIDLN", "PNRCK7" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F054115W_3", "Index on PNAN8, PNIDLN, PNACFL", new[] { "PNAN8", "PNIDLN", "PNACFL" }),
        new JdeIndex("F054115W_4", "Index on PNAN8, PNESIGN", new[] { "PNAN8", "PNESIGN" })
    };
}
