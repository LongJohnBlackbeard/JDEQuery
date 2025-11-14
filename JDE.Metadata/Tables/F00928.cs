using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00928 - .
/// </summary>
public class F00928 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCLSCONFIG.
        /// </summary>
        public const string LCLSCONFIG = "LCLSCONFIG";

        /// <summary>
        /// LCENTLOC.
        /// </summary>
        public const string LCENTLOC = "LCENTLOC";

        /// <summary>
        /// LCENTPORT.
        /// </summary>
        public const string LCENTPORT = "LCENTPORT";

        /// <summary>
        /// LCENTDESC.
        /// </summary>
        public const string LCENTDESC = "LCENTDESC";

        /// <summary>
        /// LCLDAPUID.
        /// </summary>
        public const string LCLDAPUID = "LCLDAPUID";

        /// <summary>
        /// LCLDAPPSWD.
        /// </summary>
        public const string LCLDAPPSWD = "LCLDAPPSWD";

        /// <summary>
        /// LCLDAPSRVLOC.
        /// </summary>
        public const string LCLDAPSRVLOC = "LCLDAPSRVLOC";

        /// <summary>
        /// LCLDAPSTYP.
        /// </summary>
        public const string LCLDAPSTYP = "LCLDAPSTYP";

        /// <summary>
        /// LCLDAPRENB.
        /// </summary>
        public const string LCLDAPRENB = "LCLDAPRENB";

        /// <summary>
        /// LCLDAPSSL.
        /// </summary>
        public const string LCLDAPSSL = "LCLDAPSSL";

        /// <summary>
        /// LCLDAPSTATUS.
        /// </summary>
        public const string LCLDAPSTATUS = "LCLDAPSTATUS";

        /// <summary>
        /// LCFUTTIME1.
        /// </summary>
        public const string LCFUTTIME1 = "LCFUTTIME1";

        /// <summary>
        /// LCFUTTIME2.
        /// </summary>
        public const string LCFUTTIME2 = "LCFUTTIME2";

        /// <summary>
        /// LCFUTTIME3.
        /// </summary>
        public const string LCFUTTIME3 = "LCFUTTIME3";

        /// <summary>
        /// LCFUTTIME4.
        /// </summary>
        public const string LCFUTTIME4 = "LCFUTTIME4";

        /// <summary>
        /// LCFUTTIME5.
        /// </summary>
        public const string LCFUTTIME5 = "LCFUTTIME5";

        /// <summary>
        /// LCFUTTIME6.
        /// </summary>
        public const string LCFUTTIME6 = "LCFUTTIME6";

        /// <summary>
        /// LCFUTTIME7.
        /// </summary>
        public const string LCFUTTIME7 = "LCFUTTIME7";

        /// <summary>
        /// LCFUTTIME8.
        /// </summary>
        public const string LCFUTTIME8 = "LCFUTTIME8";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F00928";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCLSCONFIG", "LCLSCONFIG", JdeDataType.String, 30, true, true),
        new JdeField("LCENTLOC", "LCENTLOC", JdeDataType.String, 60),
        new JdeField("LCENTPORT", "LCENTPORT", JdeDataType.Numeric),
        new JdeField("LCENTDESC", "LCENTDESC", JdeDataType.String, 60),
        new JdeField("LCLDAPUID", "LCLDAPUID", JdeDataType.String, 1024),
        new JdeField("LCLDAPPSWD", "LCLDAPPSWD", JdeDataType.String),
        new JdeField("LCLDAPSRVLOC", "LCLDAPSRVLOC", JdeDataType.String, 512),
        new JdeField("LCLDAPSTYP", "LCLDAPSTYP", JdeDataType.String, 6),
        new JdeField("LCLDAPRENB", "LCLDAPRENB", JdeDataType.String, 2),
        new JdeField("LCLDAPSSL", "LCLDAPSSL", JdeDataType.String, 2),
        new JdeField("LCLDAPSTATUS", "LCLDAPSTATUS", JdeDataType.String, 20),
        new JdeField("LCFUTTIME1", "LCFUTTIME1", JdeDataType.String, 2),
        new JdeField("LCFUTTIME2", "LCFUTTIME2", JdeDataType.String, 2),
        new JdeField("LCFUTTIME3", "LCFUTTIME3", JdeDataType.String, 20),
        new JdeField("LCFUTTIME4", "LCFUTTIME4", JdeDataType.String, 20),
        new JdeField("LCFUTTIME5", "LCFUTTIME5", JdeDataType.String, 60),
        new JdeField("LCFUTTIME6", "LCFUTTIME6", JdeDataType.String, 60),
        new JdeField("LCFUTTIME7", "LCFUTTIME7", JdeDataType.Numeric),
        new JdeField("LCFUTTIME8", "LCFUTTIME8", JdeDataType.Numeric),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00928_0", "Primary Key on LCLSCONFIG", new[] { "LCLSCONFIG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00928_2", "Index on LCLDAPSTYP", new[] { "LCLDAPSTYP" }),
        new JdeIndex("F00928_3", "Index on LCLDAPSTATUS, LCLDAPRENB, LCLDAPSSL, LCLDAPSTYP", new[] { "LCLDAPSTATUS", "LCLDAPRENB", "LCLDAPSSL", "LCLDAPSTYP" }),
        new JdeIndex("F00928_4", "Index on LCENTLOC, LCENTPORT, LCLDAPSTATUS", new[] { "LCENTLOC", "LCENTPORT", "LCLDAPSTATUS" }),
        new JdeIndex("F00928_5", "Index on LCENTLOC, LCENTPORT", new[] { "LCENTLOC", "LCENTPORT" })
    };
}
