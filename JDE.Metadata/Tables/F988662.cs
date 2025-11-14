using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F988662 - .
/// </summary>
public class F988662 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFWFORIG.
        /// </summary>
        public const string WFWFORIG = "WFWFORIG";

        /// <summary>
        /// WFPROCNAME.
        /// </summary>
        public const string WFPROCNAME = "WFPROCNAME";

        /// <summary>
        /// WFPROCVER.
        /// </summary>
        public const string WFPROCVER = "WFPROCVER";

        /// <summary>
        /// WFACTNAME.
        /// </summary>
        public const string WFACTNAME = "WFACTNAME";

        /// <summary>
        /// WFTAUID.
        /// </summary>
        public const string WFTAUID = "WFTAUID";

        /// <summary>
        /// WFWFDELEG.
        /// </summary>
        public const string WFWFDELEG = "WFWFDELEG";

        /// <summary>
        /// WFACTSTS.
        /// </summary>
        public const string WFACTSTS = "WFACTSTS";

        /// <summary>
        /// WFACTACT.
        /// </summary>
        public const string WFACTACT = "WFACTACT";

        /// <summary>
        /// WFWFEFFDATE.
        /// </summary>
        public const string WFWFEFFDATE = "WFWFEFFDATE";

        /// <summary>
        /// WFWFEXPIRDAT.
        /// </summary>
        public const string WFWFEXPIRDAT = "WFWFEXPIRDAT";

        /// <summary>
        /// WFWFACTIVE.
        /// </summary>
        public const string WFWFACTIVE = "WFWFACTIVE";

        /// <summary>
        /// WFWFINFO.
        /// </summary>
        public const string WFWFINFO = "WFWFINFO";

        /// <summary>
        /// WFWFFUT1.
        /// </summary>
        public const string WFWFFUT1 = "WFWFFUT1";

        /// <summary>
        /// WFWFFUT2.
        /// </summary>
        public const string WFWFFUT2 = "WFWFFUT2";

        /// <summary>
        /// WFWFFUT3.
        /// </summary>
        public const string WFWFFUT3 = "WFWFFUT3";

        /// <summary>
        /// WFWFFUT4.
        /// </summary>
        public const string WFWFFUT4 = "WFWFFUT4";

        /// <summary>
        /// WFWFFUT5.
        /// </summary>
        public const string WFWFFUT5 = "WFWFFUT5";

        /// <summary>
        /// WFWFFUT6.
        /// </summary>
        public const string WFWFFUT6 = "WFWFFUT6";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFMKEY.
        /// </summary>
        public const string WFMKEY = "WFMKEY";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F988662";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFWFORIG", "WFWFORIG", JdeDataType.Numeric, null, true, true),
        new JdeField("WFPROCNAME", "WFPROCNAME", JdeDataType.String, 20, true, true),
        new JdeField("WFPROCVER", "WFPROCVER", JdeDataType.Numeric),
        new JdeField("WFACTNAME", "WFACTNAME", JdeDataType.String, 20),
        new JdeField("WFTAUID", "WFTAUID", JdeDataType.String, 128),
        new JdeField("WFWFDELEG", "WFWFDELEG", JdeDataType.Numeric),
        new JdeField("WFACTSTS", "WFACTSTS", JdeDataType.String, 4),
        new JdeField("WFACTACT", "WFACTACT", JdeDataType.String, 4),
        new JdeField("WFWFEFFDATE", "WFWFEFFDATE", JdeDataType.Numeric, null, true, true),
        new JdeField("WFWFEXPIRDAT", "WFWFEXPIRDAT", JdeDataType.Numeric),
        new JdeField("WFWFACTIVE", "WFWFACTIVE", JdeDataType.String, 2),
        new JdeField("WFWFINFO", "WFWFINFO", JdeDataType.String, 2),
        new JdeField("WFWFFUT1", "WFWFFUT1", JdeDataType.String, 2),
        new JdeField("WFWFFUT2", "WFWFFUT2", JdeDataType.String, 2),
        new JdeField("WFWFFUT3", "WFWFFUT3", JdeDataType.String, 40),
        new JdeField("WFWFFUT4", "WFWFFUT4", JdeDataType.String, 40),
        new JdeField("WFWFFUT5", "WFWFFUT5", JdeDataType.Numeric),
        new JdeField("WFWFFUT6", "WFWFFUT6", JdeDataType.Numeric),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFMKEY", "WFMKEY", JdeDataType.String, 30),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F988662_0", "Primary Key on WFWFORIG, WFPROCNAME, WFWFEFFDATE", new[] { "WFWFORIG", "WFPROCNAME", "WFWFEFFDATE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F988662_2", "Index on WFWFORIG, WFPROCNAME", new[] { "WFWFORIG", "WFPROCNAME" })
    };
}
