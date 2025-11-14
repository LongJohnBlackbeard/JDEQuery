using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1318 - .
/// </summary>
public class F1318 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARAN8.
        /// </summary>
        public const string ARAN8 = "ARAN8";

        /// <summary>
        /// ARLANO.
        /// </summary>
        public const string ARLANO = "ARLANO";

        /// <summary>
        /// ARMCU.
        /// </summary>
        public const string ARMCU = "ARMCU";

        /// <summary>
        /// ARLOC.
        /// </summary>
        public const string ARLOC = "ARLOC";

        /// <summary>
        /// ARPRODF.
        /// </summary>
        public const string ARPRODF = "ARPRODF";

        /// <summary>
        /// ARPRODM.
        /// </summary>
        public const string ARPRODM = "ARPRODM";

        /// <summary>
        /// ARNUMB.
        /// </summary>
        public const string ARNUMB = "ARNUMB";

        /// <summary>
        /// ARITM.
        /// </summary>
        public const string ARITM = "ARITM";

        /// <summary>
        /// ARMELC.
        /// </summary>
        public const string ARMELC = "ARMELC";

        /// <summary>
        /// ARPDFL.
        /// </summary>
        public const string ARPDFL = "ARPDFL";

        /// <summary>
        /// ARSNDN.
        /// </summary>
        public const string ARSNDN = "ARSNDN";

        /// <summary>
        /// ARTYRP.
        /// </summary>
        public const string ARTYRP = "ARTYRP";

        /// <summary>
        /// ARSRVT2.
        /// </summary>
        public const string ARSRVT2 = "ARSRVT2";

        /// <summary>
        /// ARSRVT3.
        /// </summary>
        public const string ARSRVT3 = "ARSRVT3";

        /// <summary>
        /// ARDOCO.
        /// </summary>
        public const string ARDOCO = "ARDOCO";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARMKEY.
        /// </summary>
        public const string ARMKEY = "ARMKEY";

        /// <summary>
        /// ARUPMJ.
        /// </summary>
        public const string ARUPMJ = "ARUPMJ";

        /// <summary>
        /// ARUPMT.
        /// </summary>
        public const string ARUPMT = "ARUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1318";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARAN8", "ARAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ARLANO", "ARLANO", JdeDataType.Numeric, null, true, true),
        new JdeField("ARMCU", "ARMCU", JdeDataType.String, 24, true, true),
        new JdeField("ARLOC", "ARLOC", JdeDataType.String, 24, true, true),
        new JdeField("ARPRODF", "ARPRODF", JdeDataType.String, 16, true, true),
        new JdeField("ARPRODM", "ARPRODM", JdeDataType.String, 16, true, true),
        new JdeField("ARNUMB", "ARNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("ARITM", "ARITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ARMELC", "ARMELC", JdeDataType.String, 20, true, true),
        new JdeField("ARPDFL", "ARPDFL", JdeDataType.String, 2, true, true),
        new JdeField("ARSNDN", "ARSNDN", JdeDataType.String, 2),
        new JdeField("ARTYRP", "ARTYRP", JdeDataType.String, 2),
        new JdeField("ARSRVT2", "ARSRVT2", JdeDataType.String, 16),
        new JdeField("ARSRVT3", "ARSRVT3", JdeDataType.String, 16),
        new JdeField("ARDOCO", "ARDOCO", JdeDataType.Numeric),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARMKEY", "ARMKEY", JdeDataType.String, 30),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1318_0", "Primary Key on ARAN8, ARLANO, ARMCU, ARNUMB, ARLOC, ARPRODF, ARPRODM, ARITM, ARMELC, ARPDFL", new[] { "ARAN8", "ARLANO", "ARMCU", "ARNUMB", "ARLOC", "ARPRODF", "ARPRODM", "ARITM", "ARMELC", "ARPDFL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1318_2", "Index on ARAN8, ARLANO, ARMCU, ARLOC, ARPRODF, ARPRODM, ARNUMB, ARITM", new[] { "ARAN8", "ARLANO", "ARMCU", "ARLOC", "ARPRODF", "ARPRODM", "ARNUMB", "ARITM" })
    };
}
