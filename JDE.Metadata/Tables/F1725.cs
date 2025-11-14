using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1725 - .
/// </summary>
public class F1725 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STTYPS.
        /// </summary>
        public const string STTYPS = "STTYPS";

        /// <summary>
        /// STGLCCV.
        /// </summary>
        public const string STGLCCV = "STGLCCV";

        /// <summary>
        /// STGLCNC.
        /// </summary>
        public const string STGLCNC = "STGLCNC";

        /// <summary>
        /// STPHSU.
        /// </summary>
        public const string STPHSU = "STPHSU";

        /// <summary>
        /// STSOSUP.
        /// </summary>
        public const string STSOSUP = "STSOSUP";

        /// <summary>
        /// STMTHPR.
        /// </summary>
        public const string STMTHPR = "STMTHPR";

        /// <summary>
        /// STCRUN.
        /// </summary>
        public const string STCRUN = "STCRUN";

        /// <summary>
        /// STUOM2.
        /// </summary>
        public const string STUOM2 = "STUOM2";

        /// <summary>
        /// STKS01.
        /// </summary>
        public const string STKS01 = "STKS01";

        /// <summary>
        /// STKS02.
        /// </summary>
        public const string STKS02 = "STKS02";

        /// <summary>
        /// STKS03.
        /// </summary>
        public const string STKS03 = "STKS03";

        /// <summary>
        /// STKS04.
        /// </summary>
        public const string STKS04 = "STKS04";

        /// <summary>
        /// STKS05.
        /// </summary>
        public const string STKS05 = "STKS05";

        /// <summary>
        /// STCRTU.
        /// </summary>
        public const string STCRTU = "STCRTU";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STTHRESVAL.
        /// </summary>
        public const string STTHRESVAL = "STTHRESVAL";
    }

    /// <inheritdoc />
    public override string TableName => "F1725";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STTYPS", "STTYPS", JdeDataType.String, 2, true, true),
        new JdeField("STGLCCV", "STGLCCV", JdeDataType.String, 8),
        new JdeField("STGLCNC", "STGLCNC", JdeDataType.String, 8),
        new JdeField("STPHSU", "STPHSU", JdeDataType.String, 2),
        new JdeField("STSOSUP", "STSOSUP", JdeDataType.String, 2),
        new JdeField("STMTHPR", "STMTHPR", JdeDataType.String, 2),
        new JdeField("STCRUN", "STCRUN", JdeDataType.Numeric),
        new JdeField("STUOM2", "STUOM2", JdeDataType.String, 4),
        new JdeField("STKS01", "STKS01", JdeDataType.String, 20),
        new JdeField("STKS02", "STKS02", JdeDataType.String, 20),
        new JdeField("STKS03", "STKS03", JdeDataType.String, 20),
        new JdeField("STKS04", "STKS04", JdeDataType.String, 20),
        new JdeField("STKS05", "STKS05", JdeDataType.String, 20),
        new JdeField("STCRTU", "STCRTU", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STTHRESVAL", "STTHRESVAL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1725_0", "Primary Key on STTYPS", new[] { "STTYPS" }, isUnique: true, isPrimaryKey: true)
    };
}
