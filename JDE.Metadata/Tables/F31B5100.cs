using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B5100 - .
/// </summary>
public class F31B5100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACMATYP.
        /// </summary>
        public const string ACMATYP = "ACMATYP";

        /// <summary>
        /// ACDSCSMT.
        /// </summary>
        public const string ACDSCSMT = "ACDSCSMT";

        /// <summary>
        /// ACWCOPCD.
        /// </summary>
        public const string ACWCOPCD = "ACWCOPCD";

        /// <summary>
        /// ACWCDL01.
        /// </summary>
        public const string ACWCDL01 = "ACWCDL01";

        /// <summary>
        /// ACLOTV.
        /// </summary>
        public const string ACLOTV = "ACLOTV";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACTDAY.
        /// </summary>
        public const string ACTDAY = "ACTDAY";

        /// <summary>
        /// ACURCD.
        /// </summary>
        public const string ACURCD = "ACURCD";

        /// <summary>
        /// ACURAB.
        /// </summary>
        public const string ACURAB = "ACURAB";

        /// <summary>
        /// ACURAT.
        /// </summary>
        public const string ACURAT = "ACURAT";

        /// <summary>
        /// ACURDT.
        /// </summary>
        public const string ACURDT = "ACURDT";

        /// <summary>
        /// ACURRF.
        /// </summary>
        public const string ACURRF = "ACURRF";

        /// <summary>
        /// ACFFU3.
        /// </summary>
        public const string ACFFU3 = "ACFFU3";

        /// <summary>
        /// ACFFU5.
        /// </summary>
        public const string ACFFU5 = "ACFFU5";

        /// <summary>
        /// ACFFU6.
        /// </summary>
        public const string ACFFU6 = "ACFFU6";

        /// <summary>
        /// ACFFU4.
        /// </summary>
        public const string ACFFU4 = "ACFFU4";

        /// <summary>
        /// ACFFU7.
        /// </summary>
        public const string ACFFU7 = "ACFFU7";

        /// <summary>
        /// ACFFU8.
        /// </summary>
        public const string ACFFU8 = "ACFFU8";

        /// <summary>
        /// ACTFUDJ.
        /// </summary>
        public const string ACTFUDJ = "ACTFUDJ";

        /// <summary>
        /// ACTFUDJ2.
        /// </summary>
        public const string ACTFUDJ2 = "ACTFUDJ2";

        /// <summary>
        /// ACTFUDJ3.
        /// </summary>
        public const string ACTFUDJ3 = "ACTFUDJ3";
    }

    /// <inheritdoc />
    public override string TableName => "F31B5100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACMATYP", "ACMATYP", JdeDataType.String, 8, true, true),
        new JdeField("ACDSCSMT", "ACDSCSMT", JdeDataType.String, 60),
        new JdeField("ACWCOPCD", "ACWCOPCD", JdeDataType.String, 20, true, true),
        new JdeField("ACWCDL01", "ACWCDL01", JdeDataType.String, 60),
        new JdeField("ACLOTV", "ACLOTV", JdeDataType.String, 60, true, true),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACTDAY", "ACTDAY", JdeDataType.Numeric),
        new JdeField("ACURCD", "ACURCD", JdeDataType.String, 4),
        new JdeField("ACURAB", "ACURAB", JdeDataType.Numeric),
        new JdeField("ACURAT", "ACURAT", JdeDataType.Numeric),
        new JdeField("ACURDT", "ACURDT", JdeDataType.Numeric),
        new JdeField("ACURRF", "ACURRF", JdeDataType.String, 30),
        new JdeField("ACFFU3", "ACFFU3", JdeDataType.String, 20),
        new JdeField("ACFFU5", "ACFFU5", JdeDataType.String, 20),
        new JdeField("ACFFU6", "ACFFU6", JdeDataType.String, 20),
        new JdeField("ACFFU4", "ACFFU4", JdeDataType.Numeric),
        new JdeField("ACFFU7", "ACFFU7", JdeDataType.Numeric),
        new JdeField("ACFFU8", "ACFFU8", JdeDataType.Numeric),
        new JdeField("ACTFUDJ", "ACTFUDJ", JdeDataType.Numeric),
        new JdeField("ACTFUDJ2", "ACTFUDJ2", JdeDataType.Numeric),
        new JdeField("ACTFUDJ3", "ACTFUDJ3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B5100_0", "Primary Key on ACMATYP, ACWCOPCD, ACLOTV", new[] { "ACMATYP", "ACWCOPCD", "ACLOTV" }, isUnique: true, isPrimaryKey: true)
    };
}
