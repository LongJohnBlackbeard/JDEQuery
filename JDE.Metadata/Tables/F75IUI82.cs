using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI82 - .
/// </summary>
public class F75IUI82 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHUKID.
        /// </summary>
        public const string SHUKID = "SHUKID";

        /// <summary>
        /// SHI75GSTU.
        /// </summary>
        public const string SHI75GSTU = "SHI75GSTU";

        /// <summary>
        /// SHDTFR.
        /// </summary>
        public const string SHDTFR = "SHDTFR";

        /// <summary>
        /// SHDTTO.
        /// </summary>
        public const string SHDTTO = "SHDTTO";

        /// <summary>
        /// SHDL01.
        /// </summary>
        public const string SHDL01 = "SHDL01";

        /// <summary>
        /// SHDTE.
        /// </summary>
        public const string SHDTE = "SHDTE";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";

        /// <summary>
        /// SHYFUTDT1.
        /// </summary>
        public const string SHYFUTDT1 = "SHYFUTDT1";

        /// <summary>
        /// SHFUT6.
        /// </summary>
        public const string SHFUT6 = "SHFUT6";

        /// <summary>
        /// SHYT04.
        /// </summary>
        public const string SHYT04 = "SHYT04";

        /// <summary>
        /// SHYFLAG.
        /// </summary>
        public const string SHYFLAG = "SHYFLAG";

        /// <summary>
        /// SHYNUM1.
        /// </summary>
        public const string SHYNUM1 = "SHYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI82";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHUKID", "SHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SHI75GSTU", "SHI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("SHDTFR", "SHDTFR", JdeDataType.Numeric),
        new JdeField("SHDTTO", "SHDTTO", JdeDataType.Numeric),
        new JdeField("SHDL01", "SHDL01", JdeDataType.String, 60),
        new JdeField("SHDTE", "SHDTE", JdeDataType.Numeric),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric),
        new JdeField("SHYFUTDT1", "SHYFUTDT1", JdeDataType.Numeric),
        new JdeField("SHFUT6", "SHFUT6", JdeDataType.String, 60),
        new JdeField("SHYT04", "SHYT04", JdeDataType.String, 2),
        new JdeField("SHYFLAG", "SHYFLAG", JdeDataType.String, 2),
        new JdeField("SHYNUM1", "SHYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI82_0", "Primary Key on SHUKID, SHI75GSTU", new[] { "SHUKID", "SHI75GSTU" }, isUnique: true, isPrimaryKey: true)
    };
}
