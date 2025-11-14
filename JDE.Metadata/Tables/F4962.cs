using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4962 - .
/// </summary>
public class F4962 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TEVMCU.
        /// </summary>
        public const string TEVMCU = "TEVMCU";

        /// <summary>
        /// TELDNM.
        /// </summary>
        public const string TELDNM = "TELDNM";

        /// <summary>
        /// TETRPL.
        /// </summary>
        public const string TETRPL = "TETRPL";

        /// <summary>
        /// TELCMP.
        /// </summary>
        public const string TELCMP = "TELCMP";

        /// <summary>
        /// TEITM.
        /// </summary>
        public const string TEITM = "TEITM";

        /// <summary>
        /// TEOSEQ.
        /// </summary>
        public const string TEOSEQ = "TEOSEQ";

        /// <summary>
        /// TECMPN.
        /// </summary>
        public const string TECMPN = "TECMPN";

        /// <summary>
        /// TEBPFG.
        /// </summary>
        public const string TEBPFG = "TEBPFG";

        /// <summary>
        /// TESO02.
        /// </summary>
        public const string TESO02 = "TESO02";

        /// <summary>
        /// TEACMP.
        /// </summary>
        public const string TEACMP = "TEACMP";

        /// <summary>
        /// TESCLQ.
        /// </summary>
        public const string TESCLQ = "TESCLQ";

        /// <summary>
        /// TEUOM.
        /// </summary>
        public const string TEUOM = "TEUOM";

        /// <summary>
        /// TESCLP.
        /// </summary>
        public const string TESCLP = "TESCLP";

        /// <summary>
        /// TESCWT.
        /// </summary>
        public const string TESCWT = "TESCWT";

        /// <summary>
        /// TEWTUM.
        /// </summary>
        public const string TEWTUM = "TEWTUM";

        /// <summary>
        /// TESCVL.
        /// </summary>
        public const string TESCVL = "TESCVL";

        /// <summary>
        /// TEVLUM.
        /// </summary>
        public const string TEVLUM = "TEVLUM";

        /// <summary>
        /// TENLIN.
        /// </summary>
        public const string TENLIN = "TENLIN";

        /// <summary>
        /// TEQLTR.
        /// </summary>
        public const string TEQLTR = "TEQLTR";

        /// <summary>
        /// TEQLTS.
        /// </summary>
        public const string TEQLTS = "TEQLTS";

        /// <summary>
        /// TECSTU.
        /// </summary>
        public const string TECSTU = "TECSTU";

        /// <summary>
        /// TEURCD.
        /// </summary>
        public const string TEURCD = "TEURCD";

        /// <summary>
        /// TEURDT.
        /// </summary>
        public const string TEURDT = "TEURDT";

        /// <summary>
        /// TEURAT.
        /// </summary>
        public const string TEURAT = "TEURAT";

        /// <summary>
        /// TEURAB.
        /// </summary>
        public const string TEURAB = "TEURAB";

        /// <summary>
        /// TEURRF.
        /// </summary>
        public const string TEURRF = "TEURRF";

        /// <summary>
        /// TEUSER.
        /// </summary>
        public const string TEUSER = "TEUSER";

        /// <summary>
        /// TEPID.
        /// </summary>
        public const string TEPID = "TEPID";

        /// <summary>
        /// TEJOBN.
        /// </summary>
        public const string TEJOBN = "TEJOBN";

        /// <summary>
        /// TEUPMJ.
        /// </summary>
        public const string TEUPMJ = "TEUPMJ";

        /// <summary>
        /// TETDAY.
        /// </summary>
        public const string TETDAY = "TETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4962";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TEVMCU", "TEVMCU", JdeDataType.String, 24, true, true),
        new JdeField("TELDNM", "TELDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("TETRPL", "TETRPL", JdeDataType.Numeric, null, true, true),
        new JdeField("TELCMP", "TELCMP", JdeDataType.Numeric, null, true, true),
        new JdeField("TEITM", "TEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TEOSEQ", "TEOSEQ", JdeDataType.Numeric),
        new JdeField("TECMPN", "TECMPN", JdeDataType.Numeric),
        new JdeField("TEBPFG", "TEBPFG", JdeDataType.String, 2),
        new JdeField("TESO02", "TESO02", JdeDataType.String, 2),
        new JdeField("TEACMP", "TEACMP", JdeDataType.Numeric),
        new JdeField("TESCLQ", "TESCLQ", JdeDataType.Numeric),
        new JdeField("TEUOM", "TEUOM", JdeDataType.String, 4),
        new JdeField("TESCLP", "TESCLP", JdeDataType.Numeric),
        new JdeField("TESCWT", "TESCWT", JdeDataType.Numeric),
        new JdeField("TEWTUM", "TEWTUM", JdeDataType.String, 4),
        new JdeField("TESCVL", "TESCVL", JdeDataType.Numeric),
        new JdeField("TEVLUM", "TEVLUM", JdeDataType.String, 4),
        new JdeField("TENLIN", "TENLIN", JdeDataType.Numeric),
        new JdeField("TEQLTR", "TEQLTR", JdeDataType.String, 2),
        new JdeField("TEQLTS", "TEQLTS", JdeDataType.String, 2),
        new JdeField("TECSTU", "TECSTU", JdeDataType.String, 4),
        new JdeField("TEURCD", "TEURCD", JdeDataType.String, 4),
        new JdeField("TEURDT", "TEURDT", JdeDataType.Numeric),
        new JdeField("TEURAT", "TEURAT", JdeDataType.Numeric),
        new JdeField("TEURAB", "TEURAB", JdeDataType.Numeric),
        new JdeField("TEURRF", "TEURRF", JdeDataType.String, 30),
        new JdeField("TEUSER", "TEUSER", JdeDataType.String, 20),
        new JdeField("TEPID", "TEPID", JdeDataType.String, 20),
        new JdeField("TEJOBN", "TEJOBN", JdeDataType.String, 20),
        new JdeField("TEUPMJ", "TEUPMJ", JdeDataType.Numeric),
        new JdeField("TETDAY", "TETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4962_0", "Primary Key on TEVMCU, TELDNM, TETRPL, TELCMP, TEITM", new[] { "TEVMCU", "TELDNM", "TETRPL", "TELCMP", "TEITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4962_4", "Index on TEVMCU, TELDNM, TEOSEQ, TECMPN", new[] { "TEVMCU", "TELDNM", "TEOSEQ", "TECMPN" })
    };
}
