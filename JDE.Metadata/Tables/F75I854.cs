using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I854 - .
/// </summary>
public class F75I854 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPI75TCID.
        /// </summary>
        public const string RPI75TCID = "RPI75TCID";

        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPI75GSTU.
        /// </summary>
        public const string RPI75GSTU = "RPI75GSTU";

        /// <summary>
        /// RPI75BDLU.
        /// </summary>
        public const string RPI75BDLU = "RPI75BDLU";

        /// <summary>
        /// RPI75BLAA.
        /// </summary>
        public const string RPI75BLAA = "RPI75BLAA";

        /// <summary>
        /// RPDEJ.
        /// </summary>
        public const string RPDEJ = "RPDEJ";

        /// <summary>
        /// RPATXA.
        /// </summary>
        public const string RPATXA = "RPATXA";

        /// <summary>
        /// RPI75IGSTA.
        /// </summary>
        public const string RPI75IGSTA = "RPI75IGSTA";

        /// <summary>
        /// RPI75CESSA.
        /// </summary>
        public const string RPI75CESSA = "RPI75CESSA";

        /// <summary>
        /// RPYSTATUS.
        /// </summary>
        public const string RPYSTATUS = "RPYSTATUS";

        /// <summary>
        /// RPI75RECDT.
        /// </summary>
        public const string RPI75RECDT = "RPI75RECDT";

        /// <summary>
        /// RPRMK.
        /// </summary>
        public const string RPRMK = "RPRMK";

        /// <summary>
        /// RPI75CANDT.
        /// </summary>
        public const string RPI75CANDT = "RPI75CANDT";

        /// <summary>
        /// RPICU.
        /// </summary>
        public const string RPICU = "RPICU";

        /// <summary>
        /// RPICUT.
        /// </summary>
        public const string RPICUT = "RPICUT";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPUPMT.
        /// </summary>
        public const string RPUPMT = "RPUPMT";

        /// <summary>
        /// RPYT01.
        /// </summary>
        public const string RPYT01 = "RPYT01";

        /// <summary>
        /// RPYT02.
        /// </summary>
        public const string RPYT02 = "RPYT02";

        /// <summary>
        /// RPYFUTDT1.
        /// </summary>
        public const string RPYFUTDT1 = "RPYFUTDT1";

        /// <summary>
        /// RPYFUTDT2.
        /// </summary>
        public const string RPYFUTDT2 = "RPYFUTDT2";

        /// <summary>
        /// RPYNUM1.
        /// </summary>
        public const string RPYNUM1 = "RPYNUM1";

        /// <summary>
        /// RPYNUM2.
        /// </summary>
        public const string RPYNUM2 = "RPYNUM2";
    }

    /// <inheritdoc />
    public override string TableName => "F75I854";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPI75TCID", "RPI75TCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPI75GSTU", "RPI75GSTU", JdeDataType.Numeric),
        new JdeField("RPI75BDLU", "RPI75BDLU", JdeDataType.String, 60),
        new JdeField("RPI75BLAA", "RPI75BLAA", JdeDataType.Numeric),
        new JdeField("RPDEJ", "RPDEJ", JdeDataType.Numeric),
        new JdeField("RPATXA", "RPATXA", JdeDataType.Numeric),
        new JdeField("RPI75IGSTA", "RPI75IGSTA", JdeDataType.Numeric),
        new JdeField("RPI75CESSA", "RPI75CESSA", JdeDataType.Numeric),
        new JdeField("RPYSTATUS", "RPYSTATUS", JdeDataType.String, 2),
        new JdeField("RPI75RECDT", "RPI75RECDT", JdeDataType.Numeric),
        new JdeField("RPRMK", "RPRMK", JdeDataType.String, 60),
        new JdeField("RPI75CANDT", "RPI75CANDT", JdeDataType.Numeric),
        new JdeField("RPICU", "RPICU", JdeDataType.Numeric),
        new JdeField("RPICUT", "RPICUT", JdeDataType.String, 4),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric),
        new JdeField("RPYT01", "RPYT01", JdeDataType.String, 2),
        new JdeField("RPYT02", "RPYT02", JdeDataType.String, 2),
        new JdeField("RPYFUTDT1", "RPYFUTDT1", JdeDataType.Numeric),
        new JdeField("RPYFUTDT2", "RPYFUTDT2", JdeDataType.Numeric),
        new JdeField("RPYNUM1", "RPYNUM1", JdeDataType.Numeric),
        new JdeField("RPYNUM2", "RPYNUM2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I854_0", "Primary Key on RPI75TCID, RPDOC, RPDCT, RPKCO, RPSFX", new[] { "RPI75TCID", "RPDOC", "RPDCT", "RPKCO", "RPSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I854_2", "Index on RPDOC, RPDCT, RPKCO, RPSFX, RPYSTATUS", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX", "RPYSTATUS" })
    };
}
