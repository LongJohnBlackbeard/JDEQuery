using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1732 - .
/// </summary>
public class F1732 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RAITYPE.
        /// </summary>
        public const string RAITYPE = "RAITYPE";

        /// <summary>
        /// RAREGSTS.
        /// </summary>
        public const string RAREGSTS = "RAREGSTS";

        /// <summary>
        /// RAREGSTSN.
        /// </summary>
        public const string RAREGSTSN = "RAREGSTSN";

        /// <summary>
        /// RAREGSTS1.
        /// </summary>
        public const string RAREGSTS1 = "RAREGSTS1";

        /// <summary>
        /// RAREGSTS2.
        /// </summary>
        public const string RAREGSTS2 = "RAREGSTS2";

        /// <summary>
        /// RAREGSTS3.
        /// </summary>
        public const string RAREGSTS3 = "RAREGSTS3";

        /// <summary>
        /// RAREGSTS4.
        /// </summary>
        public const string RAREGSTS4 = "RAREGSTS4";

        /// <summary>
        /// RAREGSTS5.
        /// </summary>
        public const string RAREGSTS5 = "RAREGSTS5";

        /// <summary>
        /// RAYN01.
        /// </summary>
        public const string RAYN01 = "RAYN01";

        /// <summary>
        /// RAYN02.
        /// </summary>
        public const string RAYN02 = "RAYN02";

        /// <summary>
        /// RAYN03.
        /// </summary>
        public const string RAYN03 = "RAYN03";

        /// <summary>
        /// RAYN04.
        /// </summary>
        public const string RAYN04 = "RAYN04";

        /// <summary>
        /// RAYN05.
        /// </summary>
        public const string RAYN05 = "RAYN05";

        /// <summary>
        /// RAYN06.
        /// </summary>
        public const string RAYN06 = "RAYN06";

        /// <summary>
        /// RAYN07.
        /// </summary>
        public const string RAYN07 = "RAYN07";

        /// <summary>
        /// RAYN08.
        /// </summary>
        public const string RAYN08 = "RAYN08";

        /// <summary>
        /// RAYN09.
        /// </summary>
        public const string RAYN09 = "RAYN09";

        /// <summary>
        /// RAYN10.
        /// </summary>
        public const string RAYN10 = "RAYN10";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RAUPMT.
        /// </summary>
        public const string RAUPMT = "RAUPMT";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";
    }

    /// <inheritdoc />
    public override string TableName => "F1732";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAITYPE", "RAITYPE", JdeDataType.String, 2, true, true),
        new JdeField("RAREGSTS", "RAREGSTS", JdeDataType.String, 6, true, true),
        new JdeField("RAREGSTSN", "RAREGSTSN", JdeDataType.String, 6),
        new JdeField("RAREGSTS1", "RAREGSTS1", JdeDataType.String, 6),
        new JdeField("RAREGSTS2", "RAREGSTS2", JdeDataType.String, 6),
        new JdeField("RAREGSTS3", "RAREGSTS3", JdeDataType.String, 6),
        new JdeField("RAREGSTS4", "RAREGSTS4", JdeDataType.String, 6),
        new JdeField("RAREGSTS5", "RAREGSTS5", JdeDataType.String, 6),
        new JdeField("RAYN01", "RAYN01", JdeDataType.String, 2),
        new JdeField("RAYN02", "RAYN02", JdeDataType.String, 2),
        new JdeField("RAYN03", "RAYN03", JdeDataType.String, 2),
        new JdeField("RAYN04", "RAYN04", JdeDataType.String, 2),
        new JdeField("RAYN05", "RAYN05", JdeDataType.String, 2),
        new JdeField("RAYN06", "RAYN06", JdeDataType.String, 2),
        new JdeField("RAYN07", "RAYN07", JdeDataType.String, 2),
        new JdeField("RAYN08", "RAYN08", JdeDataType.String, 2),
        new JdeField("RAYN09", "RAYN09", JdeDataType.String, 2),
        new JdeField("RAYN10", "RAYN10", JdeDataType.String, 2),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1732_0", "Primary Key on RAITYPE, RAREGSTS", new[] { "RAITYPE", "RAREGSTS" }, isUnique: true, isPrimaryKey: true)
    };
}
