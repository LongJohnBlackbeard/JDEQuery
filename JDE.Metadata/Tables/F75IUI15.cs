using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI15 - .
/// </summary>
public class F75IUI15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRRTN.
        /// </summary>
        public const string TRRTN = "TRRTN";

        /// <summary>
        /// TRI75CATVL.
        /// </summary>
        public const string TRI75CATVL = "TRI75CATVL";

        /// <summary>
        /// TRI75CATCO.
        /// </summary>
        public const string TRI75CATCO = "TRI75CATCO";

        /// <summary>
        /// TRI75CATTY.
        /// </summary>
        public const string TRI75CATTY = "TRI75CATTY";

        /// <summary>
        /// TREFTJ.
        /// </summary>
        public const string TREFTJ = "TREFTJ";

        /// <summary>
        /// TRI75CGSTR.
        /// </summary>
        public const string TRI75CGSTR = "TRI75CGSTR";

        /// <summary>
        /// TRI75SGSTR.
        /// </summary>
        public const string TRI75SGSTR = "TRI75SGSTR";

        /// <summary>
        /// TRI75IGSTR.
        /// </summary>
        public const string TRI75IGSTR = "TRI75IGSTR";

        /// <summary>
        /// TRI75CESSR.
        /// </summary>
        public const string TRI75CESSR = "TRI75CESSR";

        /// <summary>
        /// TRJOBS.
        /// </summary>
        public const string TRJOBS = "TRJOBS";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRRTN", "TRRTN", JdeDataType.Numeric, null, true, true),
        new JdeField("TRI75CATVL", "TRI75CATVL", JdeDataType.String, 40),
        new JdeField("TRI75CATCO", "TRI75CATCO", JdeDataType.Numeric),
        new JdeField("TRI75CATTY", "TRI75CATTY", JdeDataType.String, 6),
        new JdeField("TREFTJ", "TREFTJ", JdeDataType.Numeric),
        new JdeField("TRI75CGSTR", "TRI75CGSTR", JdeDataType.Numeric),
        new JdeField("TRI75SGSTR", "TRI75SGSTR", JdeDataType.Numeric),
        new JdeField("TRI75IGSTR", "TRI75IGSTR", JdeDataType.Numeric),
        new JdeField("TRI75CESSR", "TRI75CESSR", JdeDataType.Numeric),
        new JdeField("TRJOBS", "TRJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20, true, true),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI15_0", "Primary Key on TRRTN, TRJOBS, TRUSER", new[] { "TRRTN", "TRJOBS", "TRUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
