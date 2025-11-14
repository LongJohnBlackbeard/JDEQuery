using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F95 - .
/// </summary>
public class F51F95 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QTCCT.
        /// </summary>
        public const string QTCCT = "QTCCT";

        /// <summary>
        /// QT51FEFD.
        /// </summary>
        public const string QT51FEFD = "QT51FEFD";

        /// <summary>
        /// QT51FRL.
        /// </summary>
        public const string QT51FRL = "QT51FRL";

        /// <summary>
        /// QT51FSEQ.
        /// </summary>
        public const string QT51FSEQ = "QT51FSEQ";

        /// <summary>
        /// QT51FFN.
        /// </summary>
        public const string QT51FFN = "QT51FFN";

        /// <summary>
        /// QT51FVALR.
        /// </summary>
        public const string QT51FVALR = "QT51FVALR";

        /// <summary>
        /// QT51FVAL.
        /// </summary>
        public const string QT51FVAL = "QT51FVAL";

        /// <summary>
        /// QT51FNVAL.
        /// </summary>
        public const string QT51FNVAL = "QT51FNVAL";

        /// <summary>
        /// QTENTJ.
        /// </summary>
        public const string QTENTJ = "QTENTJ";

        /// <summary>
        /// QTTENT.
        /// </summary>
        public const string QTTENT = "QTTENT";

        /// <summary>
        /// QTUSER.
        /// </summary>
        public const string QTUSER = "QTUSER";

        /// <summary>
        /// QTUPMJ.
        /// </summary>
        public const string QTUPMJ = "QTUPMJ";

        /// <summary>
        /// QTUPMT.
        /// </summary>
        public const string QTUPMT = "QTUPMT";

        /// <summary>
        /// QTJOBN.
        /// </summary>
        public const string QTJOBN = "QTJOBN";

        /// <summary>
        /// QTPID.
        /// </summary>
        public const string QTPID = "QTPID";

        /// <summary>
        /// QTMKEY.
        /// </summary>
        public const string QTMKEY = "QTMKEY";

        /// <summary>
        /// QTTORG.
        /// </summary>
        public const string QTTORG = "QTTORG";

        /// <summary>
        /// QT51FAO.
        /// </summary>
        public const string QT51FAO = "QT51FAO";
    }

    /// <inheritdoc />
    public override string TableName => "F51F95";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QTCCT", "QTCCT", JdeDataType.String, 2, true, true),
        new JdeField("QT51FEFD", "QT51FEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("QT51FRL", "QT51FRL", JdeDataType.Numeric, null, true, true),
        new JdeField("QT51FSEQ", "QT51FSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("QT51FFN", "QT51FFN", JdeDataType.String, 12),
        new JdeField("QT51FVALR", "QT51FVALR", JdeDataType.String, 4),
        new JdeField("QT51FVAL", "QT51FVAL", JdeDataType.String, 12),
        new JdeField("QT51FNVAL", "QT51FNVAL", JdeDataType.Numeric),
        new JdeField("QTENTJ", "QTENTJ", JdeDataType.Numeric),
        new JdeField("QTTENT", "QTTENT", JdeDataType.Numeric),
        new JdeField("QTUSER", "QTUSER", JdeDataType.String, 20),
        new JdeField("QTUPMJ", "QTUPMJ", JdeDataType.Numeric),
        new JdeField("QTUPMT", "QTUPMT", JdeDataType.Numeric),
        new JdeField("QTJOBN", "QTJOBN", JdeDataType.String, 20),
        new JdeField("QTPID", "QTPID", JdeDataType.String, 20),
        new JdeField("QTMKEY", "QTMKEY", JdeDataType.String, 30),
        new JdeField("QTTORG", "QTTORG", JdeDataType.String, 20),
        new JdeField("QT51FAO", "QT51FAO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F95_0", "Primary Key on QTCCT, QT51FEFD, QT51FRL, QT51FSEQ", new[] { "QTCCT", "QT51FEFD", "QT51FRL", "QT51FSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51F95_2", "Index on QTCCT, QT51FEFD", new[] { "QTCCT", "QT51FEFD" })
    };
}
