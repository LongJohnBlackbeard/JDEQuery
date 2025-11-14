using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0916 - .
/// </summary>
public class F0916 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GHPOST.
        /// </summary>
        public const string GHPOST = "GHPOST";

        /// <summary>
        /// GHGLBA.
        /// </summary>
        public const string GHGLBA = "GHGLBA";

        /// <summary>
        /// GHAM.
        /// </summary>
        public const string GHAM = "GHAM";

        /// <summary>
        /// GHSTMD.
        /// </summary>
        public const string GHSTMD = "GHSTMD";

        /// <summary>
        /// GHDTEJ.
        /// </summary>
        public const string GHDTEJ = "GHDTEJ";

        /// <summary>
        /// GHSTBA.
        /// </summary>
        public const string GHSTBA = "GHSTBA";

        /// <summary>
        /// GHBGBL.
        /// </summary>
        public const string GHBGBL = "GHBGBL";

        /// <summary>
        /// GHENBL.
        /// </summary>
        public const string GHENBL = "GHENBL";

        /// <summary>
        /// GHNTRN.
        /// </summary>
        public const string GHNTRN = "GHNTRN";

        /// <summary>
        /// GHITRN.
        /// </summary>
        public const string GHITRN = "GHITRN";

        /// <summary>
        /// GHREMA.
        /// </summary>
        public const string GHREMA = "GHREMA";

        /// <summary>
        /// GHTDEB.
        /// </summary>
        public const string GHTDEB = "GHTDEB";

        /// <summary>
        /// GHDEBE.
        /// </summary>
        public const string GHDEBE = "GHDEBE";

        /// <summary>
        /// GHTCRE.
        /// </summary>
        public const string GHTCRE = "GHTCRE";

        /// <summary>
        /// GHICU.
        /// </summary>
        public const string GHICU = "GHICU";

        /// <summary>
        /// GHCREE.
        /// </summary>
        public const string GHCREE = "GHCREE";

        /// <summary>
        /// GHUSER.
        /// </summary>
        public const string GHUSER = "GHUSER";

        /// <summary>
        /// GHJOBN.
        /// </summary>
        public const string GHJOBN = "GHJOBN";

        /// <summary>
        /// GHUPMJ.
        /// </summary>
        public const string GHUPMJ = "GHUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F0916";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GHPOST", "GHPOST", JdeDataType.String, 2),
        new JdeField("GHGLBA", "GHGLBA", JdeDataType.String, 16, true, true),
        new JdeField("GHAM", "GHAM", JdeDataType.String, 2),
        new JdeField("GHSTMD", "GHSTMD", JdeDataType.Numeric, null, true, true),
        new JdeField("GHDTEJ", "GHDTEJ", JdeDataType.Numeric),
        new JdeField("GHSTBA", "GHSTBA", JdeDataType.String, 30, true, true),
        new JdeField("GHBGBL", "GHBGBL", JdeDataType.Numeric),
        new JdeField("GHENBL", "GHENBL", JdeDataType.Numeric),
        new JdeField("GHNTRN", "GHNTRN", JdeDataType.Numeric),
        new JdeField("GHITRN", "GHITRN", JdeDataType.Numeric),
        new JdeField("GHREMA", "GHREMA", JdeDataType.Numeric),
        new JdeField("GHTDEB", "GHTDEB", JdeDataType.Numeric),
        new JdeField("GHDEBE", "GHDEBE", JdeDataType.Numeric),
        new JdeField("GHTCRE", "GHTCRE", JdeDataType.Numeric),
        new JdeField("GHICU", "GHICU", JdeDataType.Numeric),
        new JdeField("GHCREE", "GHCREE", JdeDataType.Numeric),
        new JdeField("GHUSER", "GHUSER", JdeDataType.String, 20),
        new JdeField("GHJOBN", "GHJOBN", JdeDataType.String, 20),
        new JdeField("GHUPMJ", "GHUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0916_0", "Primary Key on GHGLBA, GHSTMD, GHSTBA", new[] { "GHGLBA", "GHSTMD", "GHSTBA" }, isUnique: true, isPrimaryKey: true)
    };
}
