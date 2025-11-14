using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4096 - .
/// </summary>
public class F4096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FAANUM.
        /// </summary>
        public const string FAANUM = "FAANUM";

        /// <summary>
        /// FAAST.
        /// </summary>
        public const string FAAST = "FAAST";

        /// <summary>
        /// FACO.
        /// </summary>
        public const string FACO = "FACO";

        /// <summary>
        /// FAITEM.
        /// </summary>
        public const string FAITEM = "FAITEM";

        /// <summary>
        /// FAOBJF.
        /// </summary>
        public const string FAOBJF = "FAOBJF";

        /// <summary>
        /// FAOBJT.
        /// </summary>
        public const string FAOBJT = "FAOBJT";

        /// <summary>
        /// FADCTO.
        /// </summary>
        public const string FADCTO = "FADCTO";

        /// <summary>
        /// FA_1RT.
        /// </summary>
        public const string FA_1RT = "FA_1RT";

        /// <summary>
        /// FAEL.
        /// </summary>
        public const string FAEL = "FAEL";

        /// <summary>
        /// FADL01.
        /// </summary>
        public const string FADL01 = "FADL01";

        /// <summary>
        /// FASBLT.
        /// </summary>
        public const string FASBLT = "FASBLT";

        /// <summary>
        /// FASEGS.
        /// </summary>
        public const string FASEGS = "FASEGS";

        /// <summary>
        /// FASFIT.
        /// </summary>
        public const string FASFIT = "FASFIT";

        /// <summary>
        /// FASFDT.
        /// </summary>
        public const string FASFDT = "FASFDT";

        /// <summary>
        /// FAABT1.
        /// </summary>
        public const string FAABT1 = "FAABT1";

        /// <summary>
        /// FAFILE.
        /// </summary>
        public const string FAFILE = "FAFILE";

        /// <summary>
        /// FAPID.
        /// </summary>
        public const string FAPID = "FAPID";

        /// <summary>
        /// FAJOBN.
        /// </summary>
        public const string FAJOBN = "FAJOBN";

        /// <summary>
        /// FAUSER.
        /// </summary>
        public const string FAUSER = "FAUSER";

        /// <summary>
        /// FAUPMJ.
        /// </summary>
        public const string FAUPMJ = "FAUPMJ";

        /// <summary>
        /// FATDAY.
        /// </summary>
        public const string FATDAY = "FATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FAANUM", "FAANUM", JdeDataType.Numeric, null, true, true),
        new JdeField("FAAST", "FAAST", JdeDataType.String, 16, true, true),
        new JdeField("FACO", "FACO", JdeDataType.String, 10, true, true),
        new JdeField("FAITEM", "FAITEM", JdeDataType.String, 12, true, true),
        new JdeField("FAOBJF", "FAOBJF", JdeDataType.String, 12, true, true),
        new JdeField("FAOBJT", "FAOBJT", JdeDataType.String, 12, true, true),
        new JdeField("FADCTO", "FADCTO", JdeDataType.String, 4, true, true),
        new JdeField("FA_1RT", "FA_1RT", JdeDataType.String, 2, true, true),
        new JdeField("FAEL", "FAEL", JdeDataType.Numeric, null, true, true),
        new JdeField("FADL01", "FADL01", JdeDataType.String, 60),
        new JdeField("FASBLT", "FASBLT", JdeDataType.String, 2),
        new JdeField("FASEGS", "FASEGS", JdeDataType.Numeric),
        new JdeField("FASFIT", "FASFIT", JdeDataType.String, 20),
        new JdeField("FASFDT", "FASFDT", JdeDataType.String, 2),
        new JdeField("FAABT1", "FAABT1", JdeDataType.String, 2),
        new JdeField("FAFILE", "FAFILE", JdeDataType.String, 20),
        new JdeField("FAPID", "FAPID", JdeDataType.String, 20),
        new JdeField("FAJOBN", "FAJOBN", JdeDataType.String, 20),
        new JdeField("FAUSER", "FAUSER", JdeDataType.String, 20),
        new JdeField("FAUPMJ", "FAUPMJ", JdeDataType.Numeric),
        new JdeField("FATDAY", "FATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4096_0", "Primary Key on FAANUM, FACO, FAAST, FAITEM, FAOBJF, FAOBJT, FADCTO, FAEL, FA_1RT", new[] { "FAANUM", "FACO", "FAAST", "FAITEM", "FAOBJF", "FAOBJT", "FADCTO", "FAEL", "FA_1RT" }, isUnique: true, isPrimaryKey: true)
    };
}
