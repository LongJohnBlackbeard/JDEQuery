using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00165T - .
/// </summary>
public class F00165T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDOBNM.
        /// </summary>
        public const string GDOBNM = "GDOBNM";

        /// <summary>
        /// GDTXKY.
        /// </summary>
        public const string GDTXKY = "GDTXKY";

        /// <summary>
        /// GDLNGP.
        /// </summary>
        public const string GDLNGP = "GDLNGP";

        /// <summary>
        /// GDTXPO.
        /// </summary>
        public const string GDTXPO = "GDTXPO";

        /// <summary>
        /// GDCRTU.
        /// </summary>
        public const string GDCRTU = "GDCRTU";

        /// <summary>
        /// GDDQE.
        /// </summary>
        public const string GDDQE = "GDDQE";

        /// <summary>
        /// GDTENT.
        /// </summary>
        public const string GDTENT = "GDTENT";

        /// <summary>
        /// GDMUSE.
        /// </summary>
        public const string GDMUSE = "GDMUSE";

        /// <summary>
        /// GDUPMJ.
        /// </summary>
        public const string GDUPMJ = "GDUPMJ";

        /// <summary>
        /// GDTDAY.
        /// </summary>
        public const string GDTDAY = "GDTDAY";

        /// <summary>
        /// GDEFTJ.
        /// </summary>
        public const string GDEFTJ = "GDEFTJ";

        /// <summary>
        /// GDEXDJ.
        /// </summary>
        public const string GDEXDJ = "GDEXDJ";

        /// <summary>
        /// GDPNTC.
        /// </summary>
        public const string GDPNTC = "GDPNTC";

        /// <summary>
        /// GDISTM.
        /// </summary>
        public const string GDISTM = "GDISTM";

        /// <summary>
        /// GDISFL.
        /// </summary>
        public const string GDISFL = "GDISFL";

        /// <summary>
        /// GDTXTL.
        /// </summary>
        public const string GDTXTL = "GDTXTL";

        /// <summary>
        /// GDIMGL.
        /// </summary>
        public const string GDIMGL = "GDIMGL";

        /// <summary>
        /// GDOLEL.
        /// </summary>
        public const string GDOLEL = "GDOLEL";

        /// <summary>
        /// GDMSCL.
        /// </summary>
        public const string GDMSCL = "GDMSCL";

        /// <summary>
        /// GDFUTL.
        /// </summary>
        public const string GDFUTL = "GDFUTL";

        /// <summary>
        /// GDTXFT.
        /// </summary>
        public const string GDTXFT = "GDTXFT";
    }

    /// <inheritdoc />
    public override string TableName => "F00165T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDOBNM", "GDOBNM", JdeDataType.String, 20, true, true),
        new JdeField("GDTXKY", "GDTXKY", JdeDataType.String, 508, true, true),
        new JdeField("GDLNGP", "GDLNGP", JdeDataType.String, 4, true, true),
        new JdeField("GDTXPO", "GDTXPO", JdeDataType.String, 508),
        new JdeField("GDCRTU", "GDCRTU", JdeDataType.String, 20),
        new JdeField("GDDQE", "GDDQE", JdeDataType.Numeric),
        new JdeField("GDTENT", "GDTENT", JdeDataType.Numeric),
        new JdeField("GDMUSE", "GDMUSE", JdeDataType.String, 20),
        new JdeField("GDUPMJ", "GDUPMJ", JdeDataType.Numeric),
        new JdeField("GDTDAY", "GDTDAY", JdeDataType.Numeric),
        new JdeField("GDEFTJ", "GDEFTJ", JdeDataType.Numeric),
        new JdeField("GDEXDJ", "GDEXDJ", JdeDataType.Numeric),
        new JdeField("GDPNTC", "GDPNTC", JdeDataType.String, 2),
        new JdeField("GDISTM", "GDISTM", JdeDataType.String, 2),
        new JdeField("GDISFL", "GDISFL", JdeDataType.String, 2),
        new JdeField("GDTXTL", "GDTXTL", JdeDataType.Numeric),
        new JdeField("GDIMGL", "GDIMGL", JdeDataType.Numeric),
        new JdeField("GDOLEL", "GDOLEL", JdeDataType.Numeric),
        new JdeField("GDMSCL", "GDMSCL", JdeDataType.Numeric),
        new JdeField("GDFUTL", "GDFUTL", JdeDataType.Numeric),
        new JdeField("GDTXFT", "GDTXFT", JdeDataType.String)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00165T_0", "Primary Key on GDOBNM, GDTXKY, GDLNGP", new[] { "GDOBNM", "GDTXKY", "GDLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
