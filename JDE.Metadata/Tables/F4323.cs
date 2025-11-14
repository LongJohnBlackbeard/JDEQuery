using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4323 - .
/// </summary>
public class F4323 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDUKID.
        /// </summary>
        public const string PDUKID = "PDUKID";

        /// <summary>
        /// PDAN8.
        /// </summary>
        public const string PDAN8 = "PDAN8";

        /// <summary>
        /// PDVINV.
        /// </summary>
        public const string PDVINV = "PDVINV";

        /// <summary>
        /// PDDI.
        /// </summary>
        public const string PDDI = "PDDI";

        /// <summary>
        /// PDDDJ.
        /// </summary>
        public const string PDDDJ = "PDDDJ";

        /// <summary>
        /// PDPXTR.
        /// </summary>
        public const string PDPXTR = "PDPXTR";

        /// <summary>
        /// PDCRCD.
        /// </summary>
        public const string PDCRCD = "PDCRCD";

        /// <summary>
        /// PDAG.
        /// </summary>
        public const string PDAG = "PDAG";

        /// <summary>
        /// PDINV01.
        /// </summary>
        public const string PDINV01 = "PDINV01";

        /// <summary>
        /// PDINV02.
        /// </summary>
        public const string PDINV02 = "PDINV02";

        /// <summary>
        /// PDINV03.
        /// </summary>
        public const string PDINV03 = "PDINV03";

        /// <summary>
        /// PDINV04.
        /// </summary>
        public const string PDINV04 = "PDINV04";

        /// <summary>
        /// PDINV05.
        /// </summary>
        public const string PDINV05 = "PDINV05";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";

        /// <summary>
        /// PDMKEY.
        /// </summary>
        public const string PDMKEY = "PDMKEY";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F4323";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDUKID", "PDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDAN8", "PDAN8", JdeDataType.Numeric),
        new JdeField("PDVINV", "PDVINV", JdeDataType.String, 50),
        new JdeField("PDDI", "PDDI", JdeDataType.Numeric),
        new JdeField("PDDDJ", "PDDDJ", JdeDataType.Numeric),
        new JdeField("PDPXTR", "PDPXTR", JdeDataType.String, 6),
        new JdeField("PDCRCD", "PDCRCD", JdeDataType.String, 6),
        new JdeField("PDAG", "PDAG", JdeDataType.Numeric),
        new JdeField("PDINV01", "PDINV01", JdeDataType.String, 2),
        new JdeField("PDINV02", "PDINV02", JdeDataType.String, 60),
        new JdeField("PDINV03", "PDINV03", JdeDataType.Numeric),
        new JdeField("PDINV04", "PDINV04", JdeDataType.Numeric),
        new JdeField("PDINV05", "PDINV05", JdeDataType.Numeric),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric),
        new JdeField("PDMKEY", "PDMKEY", JdeDataType.String, 30),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4323_0", "Primary Key on PDUKID", new[] { "PDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
