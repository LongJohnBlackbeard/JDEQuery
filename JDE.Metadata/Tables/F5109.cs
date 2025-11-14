using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5109 - .
/// </summary>
public class F5109 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GJCTY.
        /// </summary>
        public const string GJCTY = "GJCTY";

        /// <summary>
        /// GJSUB.
        /// </summary>
        public const string GJSUB = "GJSUB";

        /// <summary>
        /// GJOBJ.
        /// </summary>
        public const string GJOBJ = "GJOBJ";

        /// <summary>
        /// GJDL01.
        /// </summary>
        public const string GJDL01 = "GJDL01";

        /// <summary>
        /// GJLDA.
        /// </summary>
        public const string GJLDA = "GJLDA";

        /// <summary>
        /// GJPEC.
        /// </summary>
        public const string GJPEC = "GJPEC";

        /// <summary>
        /// GJUM.
        /// </summary>
        public const string GJUM = "GJUM";

        /// <summary>
        /// GJWCMP.
        /// </summary>
        public const string GJWCMP = "GJWCMP";

        /// <summary>
        /// GJRCC.
        /// </summary>
        public const string GJRCC = "GJRCC";

        /// <summary>
        /// GJUCC.
        /// </summary>
        public const string GJUCC = "GJUCC";

        /// <summary>
        /// GJUCT.
        /// </summary>
        public const string GJUCT = "GJUCT";

        /// <summary>
        /// GJCCT.
        /// </summary>
        public const string GJCCT = "GJCCT";

        /// <summary>
        /// GJR002.
        /// </summary>
        public const string GJR002 = "GJR002";

        /// <summary>
        /// GJR003.
        /// </summary>
        public const string GJR003 = "GJR003";

        /// <summary>
        /// GJR004.
        /// </summary>
        public const string GJR004 = "GJR004";

        /// <summary>
        /// GJR001.
        /// </summary>
        public const string GJR001 = "GJR001";

        /// <summary>
        /// GJSUBA.
        /// </summary>
        public const string GJSUBA = "GJSUBA";

        /// <summary>
        /// GJERC.
        /// </summary>
        public const string GJERC = "GJERC";

        /// <summary>
        /// GJBILL.
        /// </summary>
        public const string GJBILL = "GJBILL";

        /// <summary>
        /// GJHTC.
        /// </summary>
        public const string GJHTC = "GJHTC";

        /// <summary>
        /// GJQLDA.
        /// </summary>
        public const string GJQLDA = "GJQLDA";

        /// <summary>
        /// GJADJENT.
        /// </summary>
        public const string GJADJENT = "GJADJENT";

        /// <summary>
        /// GJUAFL.
        /// </summary>
        public const string GJUAFL = "GJUAFL";

        /// <summary>
        /// GJJVDF.
        /// </summary>
        public const string GJJVDF = "GJJVDF";
    }

    /// <inheritdoc />
    public override string TableName => "F5109";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GJCTY", "GJCTY", JdeDataType.String, 6, true, true),
        new JdeField("GJSUB", "GJSUB", JdeDataType.String, 16, true, true),
        new JdeField("GJOBJ", "GJOBJ", JdeDataType.String, 12, true, true),
        new JdeField("GJDL01", "GJDL01", JdeDataType.String, 60),
        new JdeField("GJLDA", "GJLDA", JdeDataType.String, 2),
        new JdeField("GJPEC", "GJPEC", JdeDataType.String, 2),
        new JdeField("GJUM", "GJUM", JdeDataType.String, 4),
        new JdeField("GJWCMP", "GJWCMP", JdeDataType.String, 8),
        new JdeField("GJRCC", "GJRCC", JdeDataType.String, 16),
        new JdeField("GJUCC", "GJUCC", JdeDataType.Numeric),
        new JdeField("GJUCT", "GJUCT", JdeDataType.Numeric),
        new JdeField("GJCCT", "GJCCT", JdeDataType.String, 2),
        new JdeField("GJR002", "GJR002", JdeDataType.String, 6),
        new JdeField("GJR003", "GJR003", JdeDataType.String, 6),
        new JdeField("GJR004", "GJR004", JdeDataType.String, 6),
        new JdeField("GJR001", "GJR001", JdeDataType.String, 6),
        new JdeField("GJSUBA", "GJSUBA", JdeDataType.String, 16),
        new JdeField("GJERC", "GJERC", JdeDataType.String, 4),
        new JdeField("GJBILL", "GJBILL", JdeDataType.String, 2),
        new JdeField("GJHTC", "GJHTC", JdeDataType.String, 2),
        new JdeField("GJQLDA", "GJQLDA", JdeDataType.String, 2),
        new JdeField("GJADJENT", "GJADJENT", JdeDataType.String, 2),
        new JdeField("GJUAFL", "GJUAFL", JdeDataType.String, 2),
        new JdeField("GJJVDF", "GJJVDF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5109_0", "Primary Key on GJCTY, GJSUB, GJOBJ", new[] { "GJCTY", "GJSUB", "GJOBJ" }, isUnique: true, isPrimaryKey: true)
    };
}
