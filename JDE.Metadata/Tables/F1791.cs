using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1791 - .
/// </summary>
public class F1791 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMPRODF.
        /// </summary>
        public const string EMPRODF = "EMPRODF";

        /// <summary>
        /// EMPRODM.
        /// </summary>
        public const string EMPRODM = "EMPRODM";

        /// <summary>
        /// EMITM.
        /// </summary>
        public const string EMITM = "EMITM";

        /// <summary>
        /// EMMMCU.
        /// </summary>
        public const string EMMMCU = "EMMMCU";

        /// <summary>
        /// EMAN8.
        /// </summary>
        public const string EMAN8 = "EMAN8";

        /// <summary>
        /// EMCTR.
        /// </summary>
        public const string EMCTR = "EMCTR";

        /// <summary>
        /// EMEFTB.
        /// </summary>
        public const string EMEFTB = "EMEFTB";

        /// <summary>
        /// EMCRTU.
        /// </summary>
        public const string EMCRTU = "EMCRTU";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1791";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMPRODF", "EMPRODF", JdeDataType.String, 16, true, true),
        new JdeField("EMPRODM", "EMPRODM", JdeDataType.String, 16, true, true),
        new JdeField("EMITM", "EMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("EMMMCU", "EMMMCU", JdeDataType.String, 24, true, true),
        new JdeField("EMAN8", "EMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EMCTR", "EMCTR", JdeDataType.String, 6, true, true),
        new JdeField("EMEFTB", "EMEFTB", JdeDataType.Numeric),
        new JdeField("EMCRTU", "EMCRTU", JdeDataType.String, 20),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1791_0", "Primary Key on EMPRODF, EMPRODM, EMITM, EMMMCU, EMAN8, EMCTR", new[] { "EMPRODF", "EMPRODM", "EMITM", "EMMMCU", "EMAN8", "EMCTR" }, isUnique: true, isPrimaryKey: true)
    };
}
