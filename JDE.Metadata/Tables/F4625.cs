using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4625 - .
/// </summary>
public class F4625 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LNMCU.
        /// </summary>
        public const string LNMCU = "LNMCU";

        /// <summary>
        /// LNEXDJ.
        /// </summary>
        public const string LNEXDJ = "LNEXDJ";

        /// <summary>
        /// LNNN1.
        /// </summary>
        public const string LNNN1 = "LNNN1";

        /// <summary>
        /// LNFRMNN.
        /// </summary>
        public const string LNFRMNN = "LNFRMNN";

        /// <summary>
        /// LNTONN.
        /// </summary>
        public const string LNTONN = "LNTONN";

        /// <summary>
        /// LNFUT1.
        /// </summary>
        public const string LNFUT1 = "LNFUT1";

        /// <summary>
        /// LNFUT2.
        /// </summary>
        public const string LNFUT2 = "LNFUT2";

        /// <summary>
        /// LNFUT3.
        /// </summary>
        public const string LNFUT3 = "LNFUT3";

        /// <summary>
        /// LNFUT4.
        /// </summary>
        public const string LNFUT4 = "LNFUT4";

        /// <summary>
        /// LNFUT5.
        /// </summary>
        public const string LNFUT5 = "LNFUT5";

        /// <summary>
        /// LNUSER.
        /// </summary>
        public const string LNUSER = "LNUSER";

        /// <summary>
        /// LNPID.
        /// </summary>
        public const string LNPID = "LNPID";

        /// <summary>
        /// LNJOBN.
        /// </summary>
        public const string LNJOBN = "LNJOBN";

        /// <summary>
        /// LNUPMJ.
        /// </summary>
        public const string LNUPMJ = "LNUPMJ";

        /// <summary>
        /// LNTDAY.
        /// </summary>
        public const string LNTDAY = "LNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4625";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LNMCU", "LNMCU", JdeDataType.String, 24, true, true),
        new JdeField("LNEXDJ", "LNEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("LNNN1", "LNNN1", JdeDataType.Numeric),
        new JdeField("LNFRMNN", "LNFRMNN", JdeDataType.Numeric),
        new JdeField("LNTONN", "LNTONN", JdeDataType.Numeric),
        new JdeField("LNFUT1", "LNFUT1", JdeDataType.Numeric),
        new JdeField("LNFUT2", "LNFUT2", JdeDataType.Numeric),
        new JdeField("LNFUT3", "LNFUT3", JdeDataType.String, 60),
        new JdeField("LNFUT4", "LNFUT4", JdeDataType.String, 50),
        new JdeField("LNFUT5", "LNFUT5", JdeDataType.String, 50),
        new JdeField("LNUSER", "LNUSER", JdeDataType.String, 20),
        new JdeField("LNPID", "LNPID", JdeDataType.String, 20),
        new JdeField("LNJOBN", "LNJOBN", JdeDataType.String, 20),
        new JdeField("LNUPMJ", "LNUPMJ", JdeDataType.Numeric),
        new JdeField("LNTDAY", "LNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4625_0", "Primary Key on LNMCU, LNEXDJ", new[] { "LNMCU", "LNEXDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
