using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B31 - .
/// </summary>
public class F03B31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZGAVID.
        /// </summary>
        public const string ZGAVID = "ZGAVID";

        /// <summary>
        /// ZGAIT.
        /// </summary>
        public const string ZGAIT = "ZGAIT";

        /// <summary>
        /// ZGAN8.
        /// </summary>
        public const string ZGAN8 = "ZGAN8";

        /// <summary>
        /// ZGCO.
        /// </summary>
        public const string ZGCO = "ZGCO";

        /// <summary>
        /// ZGUKID.
        /// </summary>
        public const string ZGUKID = "ZGUKID";

        /// <summary>
        /// ZGAIPR.
        /// </summary>
        public const string ZGAIPR = "ZGAIPR";

        /// <summary>
        /// ZGDTI.
        /// </summary>
        public const string ZGDTI = "ZGDTI";

        /// <summary>
        /// ZGRMK.
        /// </summary>
        public const string ZGRMK = "ZGRMK";

        /// <summary>
        /// ZGAA1.
        /// </summary>
        public const string ZGAA1 = "ZGAA1";

        /// <summary>
        /// ZGAA2.
        /// </summary>
        public const string ZGAA2 = "ZGAA2";

        /// <summary>
        /// ZGUSER.
        /// </summary>
        public const string ZGUSER = "ZGUSER";

        /// <summary>
        /// ZGPID.
        /// </summary>
        public const string ZGPID = "ZGPID";

        /// <summary>
        /// ZGUPMJ.
        /// </summary>
        public const string ZGUPMJ = "ZGUPMJ";

        /// <summary>
        /// ZGUPMT.
        /// </summary>
        public const string ZGUPMT = "ZGUPMT";

        /// <summary>
        /// ZGJOBN.
        /// </summary>
        public const string ZGJOBN = "ZGJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZGAVID", "ZGAVID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGAIT", "ZGAIT", JdeDataType.String, 4, true, true),
        new JdeField("ZGAN8", "ZGAN8", JdeDataType.Numeric),
        new JdeField("ZGCO", "ZGCO", JdeDataType.String, 10),
        new JdeField("ZGUKID", "ZGUKID", JdeDataType.Numeric),
        new JdeField("ZGAIPR", "ZGAIPR", JdeDataType.String, 2),
        new JdeField("ZGDTI", "ZGDTI", JdeDataType.Numeric),
        new JdeField("ZGRMK", "ZGRMK", JdeDataType.String, 60),
        new JdeField("ZGAA1", "ZGAA1", JdeDataType.Numeric),
        new JdeField("ZGAA2", "ZGAA2", JdeDataType.Numeric),
        new JdeField("ZGUSER", "ZGUSER", JdeDataType.String, 20),
        new JdeField("ZGPID", "ZGPID", JdeDataType.String, 20),
        new JdeField("ZGUPMJ", "ZGUPMJ", JdeDataType.Numeric),
        new JdeField("ZGUPMT", "ZGUPMT", JdeDataType.Numeric),
        new JdeField("ZGJOBN", "ZGJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B31_0", "Primary Key on ZGAVID, ZGAIT", new[] { "ZGAVID", "ZGAIT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B31_2", "Index on ZGAIT, ZGAN8, ZGCO", new[] { "ZGAIT", "ZGAN8", "ZGCO" }),
        new JdeIndex("F03B31_3", "Index on ZGAIT, ZGAN8, ZGCO, SYS_NC00016$", new[] { "ZGAIT", "ZGAN8", "ZGCO", "SYS_NC00016$" }),
        new JdeIndex("F03B31_4", "Index on SYS_NC00016$, ZGAIPR, ZGAN8, ZGCO", new[] { "SYS_NC00016$", "ZGAIPR", "ZGAN8", "ZGCO" }),
        new JdeIndex("F03B31_5", "Index on ZGAN8, ZGCO, SYS_NC00016$", new[] { "ZGAN8", "ZGCO", "SYS_NC00016$" })
    };
}
