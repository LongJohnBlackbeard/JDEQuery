using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F53101 - .
/// </summary>
public class F53101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DUSTSD.
        /// </summary>
        public const string DUSTSD = "DUSTSD";

        /// <summary>
        /// DUTYRA.
        /// </summary>
        public const string DUTYRA = "DUTYRA";

        /// <summary>
        /// DUDL01.
        /// </summary>
        public const string DUDL01 = "DUDL01";

        /// <summary>
        /// DULTA.
        /// </summary>
        public const string DULTA = "DULTA";

        /// <summary>
        /// DULTU.
        /// </summary>
        public const string DULTU = "DULTU";

        /// <summary>
        /// DUAMQT.
        /// </summary>
        public const string DUAMQT = "DUAMQT";

        /// <summary>
        /// DUUSER.
        /// </summary>
        public const string DUUSER = "DUUSER";

        /// <summary>
        /// DUPID.
        /// </summary>
        public const string DUPID = "DUPID";

        /// <summary>
        /// DUJOBN.
        /// </summary>
        public const string DUJOBN = "DUJOBN";

        /// <summary>
        /// DUUPMJ.
        /// </summary>
        public const string DUUPMJ = "DUUPMJ";

        /// <summary>
        /// DUUPMT.
        /// </summary>
        public const string DUUPMT = "DUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F53101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DUSTSD", "DUSTSD", JdeDataType.String, 4, true, true),
        new JdeField("DUTYRA", "DUTYRA", JdeDataType.String, 2, true, true),
        new JdeField("DUDL01", "DUDL01", JdeDataType.String, 60),
        new JdeField("DULTA", "DULTA", JdeDataType.String, 4),
        new JdeField("DULTU", "DULTU", JdeDataType.String, 4),
        new JdeField("DUAMQT", "DUAMQT", JdeDataType.String, 2),
        new JdeField("DUUSER", "DUUSER", JdeDataType.String, 20),
        new JdeField("DUPID", "DUPID", JdeDataType.String, 20),
        new JdeField("DUJOBN", "DUJOBN", JdeDataType.String, 20),
        new JdeField("DUUPMJ", "DUUPMJ", JdeDataType.Numeric),
        new JdeField("DUUPMT", "DUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F53101_0", "Primary Key on DUSTSD, DUTYRA", new[] { "DUSTSD", "DUTYRA" }, isUnique: true, isPrimaryKey: true)
    };
}
