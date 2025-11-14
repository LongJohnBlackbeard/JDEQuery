using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07900 - .
/// </summary>
public class F07900 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCCTR.
        /// </summary>
        public const string NCCTR = "NCCTR";

        /// <summary>
        /// NCFY.
        /// </summary>
        public const string NCFY = "NCFY";

        /// <summary>
        /// NCDFY.
        /// </summary>
        public const string NCDFY = "NCDFY";

        /// <summary>
        /// NCD01.
        /// </summary>
        public const string NCD01 = "NCD01";

        /// <summary>
        /// NCD02.
        /// </summary>
        public const string NCD02 = "NCD02";

        /// <summary>
        /// NCD03.
        /// </summary>
        public const string NCD03 = "NCD03";

        /// <summary>
        /// NCD04.
        /// </summary>
        public const string NCD04 = "NCD04";

        /// <summary>
        /// NCD05.
        /// </summary>
        public const string NCD05 = "NCD05";

        /// <summary>
        /// NCD06.
        /// </summary>
        public const string NCD06 = "NCD06";

        /// <summary>
        /// NCD07.
        /// </summary>
        public const string NCD07 = "NCD07";

        /// <summary>
        /// NCD08.
        /// </summary>
        public const string NCD08 = "NCD08";

        /// <summary>
        /// NCD09.
        /// </summary>
        public const string NCD09 = "NCD09";

        /// <summary>
        /// NCD10.
        /// </summary>
        public const string NCD10 = "NCD10";

        /// <summary>
        /// NCD11.
        /// </summary>
        public const string NCD11 = "NCD11";

        /// <summary>
        /// NCD12.
        /// </summary>
        public const string NCD12 = "NCD12";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F07900";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCCTR", "NCCTR", JdeDataType.String, 6, true, true),
        new JdeField("NCFY", "NCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("NCDFY", "NCDFY", JdeDataType.Numeric),
        new JdeField("NCD01", "NCD01", JdeDataType.Numeric),
        new JdeField("NCD02", "NCD02", JdeDataType.Numeric),
        new JdeField("NCD03", "NCD03", JdeDataType.Numeric),
        new JdeField("NCD04", "NCD04", JdeDataType.Numeric),
        new JdeField("NCD05", "NCD05", JdeDataType.Numeric),
        new JdeField("NCD06", "NCD06", JdeDataType.Numeric),
        new JdeField("NCD07", "NCD07", JdeDataType.Numeric),
        new JdeField("NCD08", "NCD08", JdeDataType.Numeric),
        new JdeField("NCD09", "NCD09", JdeDataType.Numeric),
        new JdeField("NCD10", "NCD10", JdeDataType.Numeric),
        new JdeField("NCD11", "NCD11", JdeDataType.Numeric),
        new JdeField("NCD12", "NCD12", JdeDataType.Numeric),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07900_0", "Primary Key on NCCTR, NCFY", new[] { "NCCTR", "NCFY" }, isUnique: true, isPrimaryKey: true)
    };
}
