using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I864 - .
/// </summary>
public class F75I864 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMI75TSCT.
        /// </summary>
        public const string RMI75TSCT = "RMI75TSCT";

        /// <summary>
        /// RMI75DTBG.
        /// </summary>
        public const string RMI75DTBG = "RMI75DTBG";

        /// <summary>
        /// RMI75DTEN.
        /// </summary>
        public const string RMI75DTEN = "RMI75DTEN";

        /// <summary>
        /// RMGLC.
        /// </summary>
        public const string RMGLC = "RMGLC";

        /// <summary>
        /// RMI75TSRT.
        /// </summary>
        public const string RMI75TSRT = "RMI75TSRT";

        /// <summary>
        /// RMI75TSCRL.
        /// </summary>
        public const string RMI75TSCRL = "RMI75TSCRL";

        /// <summary>
        /// RMI75TSPLR.
        /// </summary>
        public const string RMI75TSPLR = "RMI75TSPLR";

        /// <summary>
        /// RMPYR.
        /// </summary>
        public const string RMPYR = "RMPYR";

        /// <summary>
        /// RMI75TAUT.
        /// </summary>
        public const string RMI75TAUT = "RMI75TAUT";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMPID.
        /// </summary>
        public const string RMPID = "RMPID";

        /// <summary>
        /// RMJOBN.
        /// </summary>
        public const string RMJOBN = "RMJOBN";

        /// <summary>
        /// RMUPMJ.
        /// </summary>
        public const string RMUPMJ = "RMUPMJ";

        /// <summary>
        /// RMUPMT.
        /// </summary>
        public const string RMUPMT = "RMUPMT";

        /// <summary>
        /// RMYFUTDT.
        /// </summary>
        public const string RMYFUTDT = "RMYFUTDT";

        /// <summary>
        /// RMFFU4.
        /// </summary>
        public const string RMFFU4 = "RMFFU4";

        /// <summary>
        /// RMFUT3.
        /// </summary>
        public const string RMFUT3 = "RMFUT3";

        /// <summary>
        /// RMX2.
        /// </summary>
        public const string RMX2 = "RMX2";

        /// <summary>
        /// RMFUTCH1.
        /// </summary>
        public const string RMFUTCH1 = "RMFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I864";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMI75TSCT", "RMI75TSCT", JdeDataType.String, 4, true, true),
        new JdeField("RMI75DTBG", "RMI75DTBG", JdeDataType.Numeric, null, true, true),
        new JdeField("RMI75DTEN", "RMI75DTEN", JdeDataType.Numeric, null, true, true),
        new JdeField("RMGLC", "RMGLC", JdeDataType.String, 8),
        new JdeField("RMI75TSRT", "RMI75TSRT", JdeDataType.Numeric),
        new JdeField("RMI75TSCRL", "RMI75TSCRL", JdeDataType.Numeric),
        new JdeField("RMI75TSPLR", "RMI75TSPLR", JdeDataType.Numeric),
        new JdeField("RMPYR", "RMPYR", JdeDataType.Numeric),
        new JdeField("RMI75TAUT", "RMI75TAUT", JdeDataType.Numeric),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMPID", "RMPID", JdeDataType.String, 20),
        new JdeField("RMJOBN", "RMJOBN", JdeDataType.String, 20),
        new JdeField("RMUPMJ", "RMUPMJ", JdeDataType.Numeric),
        new JdeField("RMUPMT", "RMUPMT", JdeDataType.Numeric),
        new JdeField("RMYFUTDT", "RMYFUTDT", JdeDataType.Numeric),
        new JdeField("RMFFU4", "RMFFU4", JdeDataType.Numeric),
        new JdeField("RMFUT3", "RMFUT3", JdeDataType.String, 60),
        new JdeField("RMX2", "RMX2", JdeDataType.String, 2),
        new JdeField("RMFUTCH1", "RMFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I864_0", "Primary Key on RMI75TSCT, RMI75DTBG, RMI75DTEN", new[] { "RMI75TSCT", "RMI75DTBG", "RMI75DTEN" }, isUnique: true, isPrimaryKey: true)
    };
}
