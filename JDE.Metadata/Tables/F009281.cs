using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F009281 - .
/// </summary>
public class F009281 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCESATTNAM.
        /// </summary>
        public const string LCESATTNAM = "LCESATTNAM";

        /// <summary>
        /// LCLSCONFIG.
        /// </summary>
        public const string LCLSCONFIG = "LCLSCONFIG";

        /// <summary>
        /// LCLSATTVAL.
        /// </summary>
        public const string LCLSATTVAL = "LCLSATTVAL";

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
    public override string TableName => "F009281";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCESATTNAM", "LCESATTNAM", JdeDataType.String, 20, true, true),
        new JdeField("LCLSCONFIG", "LCLSCONFIG", JdeDataType.String, 30, true, true),
        new JdeField("LCLSATTVAL", "LCLSATTVAL", JdeDataType.String, 1024),
        new JdeField("LCFUTTIME1", "LCFUTTIME1", JdeDataType.String, 2),
        new JdeField("LCFUTTIME2", "LCFUTTIME2", JdeDataType.String, 2),
        new JdeField("LCFUTTIME3", "LCFUTTIME3", JdeDataType.String, 20),
        new JdeField("LCFUTTIME4", "LCFUTTIME4", JdeDataType.String, 20),
        new JdeField("LCFUTTIME5", "LCFUTTIME5", JdeDataType.String, 60),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F009281_0", "Primary Key on LCESATTNAM, LCLSCONFIG", new[] { "LCESATTNAM", "LCLSCONFIG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F009281_2", "Index on LCLSCONFIG", new[] { "LCLSCONFIG" })
    };
}
