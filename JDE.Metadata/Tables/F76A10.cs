using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A10 - .
/// </summary>
public class F76A10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDATXC.
        /// </summary>
        public const string TDATXC = "TDATXC";

        /// <summary>
        /// TDGLC.
        /// </summary>
        public const string TDGLC = "TDGLC";

        /// <summary>
        /// TDCTYA.
        /// </summary>
        public const string TDCTYA = "TDCTYA";

        /// <summary>
        /// TDACCN.
        /// </summary>
        public const string TDACCN = "TDACCN";

        /// <summary>
        /// TDAICN.
        /// </summary>
        public const string TDAICN = "TDAICN";

        /// <summary>
        /// TDASIB.
        /// </summary>
        public const string TDASIB = "TDASIB";

        /// <summary>
        /// TDASGC.
        /// </summary>
        public const string TDASGC = "TDASGC";

        /// <summary>
        /// TDADE1.
        /// </summary>
        public const string TDADE1 = "TDADE1";

        /// <summary>
        /// TDADAB.
        /// </summary>
        public const string TDADAB = "TDADAB";

        /// <summary>
        /// TDAPTO.
        /// </summary>
        public const string TDAPTO = "TDAPTO";

        /// <summary>
        /// TDAQN8.
        /// </summary>
        public const string TDAQN8 = "TDAQN8";

        /// <summary>
        /// TDAQTM.
        /// </summary>
        public const string TDAQTM = "TDAQTM";

        /// <summary>
        /// TDAQC2.
        /// </summary>
        public const string TDAQC2 = "TDAQC2";

        /// <summary>
        /// TDAQSR.
        /// </summary>
        public const string TDAQSR = "TDAQSR";

        /// <summary>
        /// TDEFDJ.
        /// </summary>
        public const string TDEFDJ = "TDEFDJ";

        /// <summary>
        /// TDATCD.
        /// </summary>
        public const string TDATCD = "TDATCD";

        /// <summary>
        /// TDADA1.
        /// </summary>
        public const string TDADA1 = "TDADA1";

        /// <summary>
        /// TDADA2.
        /// </summary>
        public const string TDADA2 = "TDADA2";

        /// <summary>
        /// TDA001.
        /// </summary>
        public const string TDA001 = "TDA001";

        /// <summary>
        /// TDA002.
        /// </summary>
        public const string TDA002 = "TDA002";

        /// <summary>
        /// TDA003.
        /// </summary>
        public const string TDA003 = "TDA003";

        /// <summary>
        /// TDA004.
        /// </summary>
        public const string TDA004 = "TDA004";

        /// <summary>
        /// TDEV01.
        /// </summary>
        public const string TDEV01 = "TDEV01";

        /// <summary>
        /// TDEV02.
        /// </summary>
        public const string TDEV02 = "TDEV02";

        /// <summary>
        /// TDEV03.
        /// </summary>
        public const string TDEV03 = "TDEV03";
    }

    /// <inheritdoc />
    public override string TableName => "F76A10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDATXC", "TDATXC", JdeDataType.String, 20, true, true),
        new JdeField("TDGLC", "TDGLC", JdeDataType.String, 8),
        new JdeField("TDCTYA", "TDCTYA", JdeDataType.Numeric),
        new JdeField("TDACCN", "TDACCN", JdeDataType.Numeric),
        new JdeField("TDAICN", "TDAICN", JdeDataType.Numeric),
        new JdeField("TDASIB", "TDASIB", JdeDataType.Numeric),
        new JdeField("TDASGC", "TDASGC", JdeDataType.Numeric),
        new JdeField("TDADE1", "TDADE1", JdeDataType.String, 2),
        new JdeField("TDADAB", "TDADAB", JdeDataType.String, 2),
        new JdeField("TDAPTO", "TDAPTO", JdeDataType.String, 2),
        new JdeField("TDAQN8", "TDAQN8", JdeDataType.Numeric),
        new JdeField("TDAQTM", "TDAQTM", JdeDataType.Numeric),
        new JdeField("TDAQC2", "TDAQC2", JdeDataType.Numeric),
        new JdeField("TDAQSR", "TDAQSR", JdeDataType.Numeric),
        new JdeField("TDEFDJ", "TDEFDJ", JdeDataType.Numeric),
        new JdeField("TDATCD", "TDATCD", JdeDataType.String, 2),
        new JdeField("TDADA1", "TDADA1", JdeDataType.Numeric),
        new JdeField("TDADA2", "TDADA2", JdeDataType.Numeric),
        new JdeField("TDA001", "TDA001", JdeDataType.String, 6),
        new JdeField("TDA002", "TDA002", JdeDataType.String, 6),
        new JdeField("TDA003", "TDA003", JdeDataType.String, 6),
        new JdeField("TDA004", "TDA004", JdeDataType.String, 6),
        new JdeField("TDEV01", "TDEV01", JdeDataType.String, 2),
        new JdeField("TDEV02", "TDEV02", JdeDataType.String, 2),
        new JdeField("TDEV03", "TDEV03", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A10_0", "Primary Key on TDATXC", new[] { "TDATXC" }, isUnique: true, isPrimaryKey: true)
    };
}
