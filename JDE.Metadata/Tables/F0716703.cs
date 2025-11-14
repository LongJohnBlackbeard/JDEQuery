using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0716703 - .
/// </summary>
public class F0716703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EATSKID.
        /// </summary>
        public const string EATSKID = "EATSKID";

        /// <summary>
        /// EAEAEFDT.
        /// </summary>
        public const string EAEAEFDT = "EAEAEFDT";

        /// <summary>
        /// EAEAJOBDES.
        /// </summary>
        public const string EAEAJOBDES = "EAEAJOBDES";

        /// <summary>
        /// EAEAJOBCD.
        /// </summary>
        public const string EAEAJOBCD = "EAEAJOBCD";

        /// <summary>
        /// EAEAURCH4.
        /// </summary>
        public const string EAEAURCH4 = "EAEAURCH4";

        /// <summary>
        /// EAEAURST9.
        /// </summary>
        public const string EAEAURST9 = "EAEAURST9";

        /// <summary>
        /// EAEAURMN4.
        /// </summary>
        public const string EAEAURMN4 = "EAEAURMN4";

        /// <summary>
        /// EAEAURCU4.
        /// </summary>
        public const string EAEAURCU4 = "EAEAURCU4";

        /// <summary>
        /// EAEAURDT4.
        /// </summary>
        public const string EAEAURDT4 = "EAEAURDT4";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0716703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EATSKID", "EATSKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEAEFDT", "EAEAEFDT", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEAJOBDES", "EAEAJOBDES", JdeDataType.String, 60),
        new JdeField("EAEAJOBCD", "EAEAJOBCD", JdeDataType.String, 12),
        new JdeField("EAEAURCH4", "EAEAURCH4", JdeDataType.String, 2),
        new JdeField("EAEAURST9", "EAEAURST9", JdeDataType.String, 60),
        new JdeField("EAEAURMN4", "EAEAURMN4", JdeDataType.Numeric),
        new JdeField("EAEAURCU4", "EAEAURCU4", JdeDataType.Numeric),
        new JdeField("EAEAURDT4", "EAEAURDT4", JdeDataType.Numeric),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0716703_0", "Primary Key on EATSKID, EAEAEFDT", new[] { "EATSKID", "EAEAEFDT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0716703_2", "Index on EATSKID, SYS_NC00015$", new[] { "EATSKID", "SYS_NC00015$" })
    };
}
