using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76432 - .
/// </summary>
public class F76432 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PJDOCO.
        /// </summary>
        public const string PJDOCO = "PJDOCO";

        /// <summary>
        /// PJDCTO.
        /// </summary>
        public const string PJDCTO = "PJDCTO";

        /// <summary>
        /// PJKCOO.
        /// </summary>
        public const string PJKCOO = "PJKCOO";

        /// <summary>
        /// PJSFXO.
        /// </summary>
        public const string PJSFXO = "PJSFXO";

        /// <summary>
        /// PJLNID.
        /// </summary>
        public const string PJLNID = "PJLNID";

        /// <summary>
        /// PJBNOP.
        /// </summary>
        public const string PJBNOP = "PJBNOP";

        /// <summary>
        /// PJBSOP.
        /// </summary>
        public const string PJBSOP = "PJBSOP";

        /// <summary>
        /// PJBCTF.
        /// </summary>
        public const string PJBCTF = "PJBCTF";

        /// <summary>
        /// PJBCLF.
        /// </summary>
        public const string PJBCLF = "PJBCLF";

        /// <summary>
        /// PJBIST.
        /// </summary>
        public const string PJBIST = "PJBIST";

        /// <summary>
        /// PJBORI.
        /// </summary>
        public const string PJBORI = "PJBORI";

        /// <summary>
        /// PJBCFC.
        /// </summary>
        public const string PJBCFC = "PJBCFC";

        /// <summary>
        /// PJBINM.
        /// </summary>
        public const string PJBINM = "PJBINM";

        /// <summary>
        /// PJUSER.
        /// </summary>
        public const string PJUSER = "PJUSER";

        /// <summary>
        /// PJPID.
        /// </summary>
        public const string PJPID = "PJPID";

        /// <summary>
        /// PJJOBN.
        /// </summary>
        public const string PJJOBN = "PJJOBN";

        /// <summary>
        /// PJUPMJ.
        /// </summary>
        public const string PJUPMJ = "PJUPMJ";

        /// <summary>
        /// PJTDAY.
        /// </summary>
        public const string PJTDAY = "PJTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76432";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PJDOCO", "PJDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PJDCTO", "PJDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PJKCOO", "PJKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PJSFXO", "PJSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PJLNID", "PJLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PJBNOP", "PJBNOP", JdeDataType.Numeric),
        new JdeField("PJBSOP", "PJBSOP", JdeDataType.String, 4),
        new JdeField("PJBCTF", "PJBCTF", JdeDataType.String, 4),
        new JdeField("PJBCLF", "PJBCLF", JdeDataType.String, 20),
        new JdeField("PJBIST", "PJBIST", JdeDataType.String, 2),
        new JdeField("PJBORI", "PJBORI", JdeDataType.String, 2),
        new JdeField("PJBCFC", "PJBCFC", JdeDataType.String, 6),
        new JdeField("PJBINM", "PJBINM", JdeDataType.String, 20),
        new JdeField("PJUSER", "PJUSER", JdeDataType.String, 20),
        new JdeField("PJPID", "PJPID", JdeDataType.String, 20),
        new JdeField("PJJOBN", "PJJOBN", JdeDataType.String, 20),
        new JdeField("PJUPMJ", "PJUPMJ", JdeDataType.Numeric),
        new JdeField("PJTDAY", "PJTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76432_0", "Primary Key on PJDOCO, PJDCTO, PJKCOO, PJSFXO, PJLNID", new[] { "PJDOCO", "PJDCTO", "PJKCOO", "PJSFXO", "PJLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
