using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700103 - .
/// </summary>
public class F700103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMSY.
        /// </summary>
        public const string EMSY = "EMSY";

        /// <summary>
        /// EMLCTR.
        /// </summary>
        public const string EMLCTR = "EMLCTR";

        /// <summary>
        /// EMDCT.
        /// </summary>
        public const string EMDCT = "EMDCT";

        /// <summary>
        /// EMTXA1.
        /// </summary>
        public const string EMTXA1 = "EMTXA1";

        /// <summary>
        /// EMK70MTHD.
        /// </summary>
        public const string EMK70MTHD = "EMK70MTHD";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F700103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMSY", "EMSY", JdeDataType.String, 8, true, true),
        new JdeField("EMLCTR", "EMLCTR", JdeDataType.String, 6, true, true),
        new JdeField("EMDCT", "EMDCT", JdeDataType.String, 4, true, true),
        new JdeField("EMTXA1", "EMTXA1", JdeDataType.String, 20, true, true),
        new JdeField("EMK70MTHD", "EMK70MTHD", JdeDataType.String, 2),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700103_0", "Primary Key on EMSY, EMLCTR, EMDCT, EMTXA1", new[] { "EMSY", "EMLCTR", "EMDCT", "EMTXA1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F700103_2", "Index on EMSY, EMLCTR", new[] { "EMSY", "EMLCTR" })
    };
}
