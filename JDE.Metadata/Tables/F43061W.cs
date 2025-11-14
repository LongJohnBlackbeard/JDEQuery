using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43061W - .
/// </summary>
public class F43061W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MUGPSP.
        /// </summary>
        public const string MUGPSP = "MUGPSP";

        /// <summary>
        /// MUUKID.
        /// </summary>
        public const string MUUKID = "MUUKID";

        /// <summary>
        /// MUMCU.
        /// </summary>
        public const string MUMCU = "MUMCU";

        /// <summary>
        /// MUAN8.
        /// </summary>
        public const string MUAN8 = "MUAN8";

        /// <summary>
        /// MUITM.
        /// </summary>
        public const string MUITM = "MUITM";

        /// <summary>
        /// MUCATN.
        /// </summary>
        public const string MUCATN = "MUCATN";

        /// <summary>
        /// MUCRCD.
        /// </summary>
        public const string MUCRCD = "MUCRCD";

        /// <summary>
        /// MUUOM.
        /// </summary>
        public const string MUUOM = "MUUOM";

        /// <summary>
        /// MULITM.
        /// </summary>
        public const string MULITM = "MULITM";

        /// <summary>
        /// MUAITM.
        /// </summary>
        public const string MUAITM = "MUAITM";

        /// <summary>
        /// MUPRRC.
        /// </summary>
        public const string MUPRRC = "MUPRRC";

        /// <summary>
        /// MUUORG.
        /// </summary>
        public const string MUUORG = "MUUORG";

        /// <summary>
        /// MUEFTJ.
        /// </summary>
        public const string MUEFTJ = "MUEFTJ";

        /// <summary>
        /// MUEXDJ.
        /// </summary>
        public const string MUEXDJ = "MUEXDJ";

        /// <summary>
        /// MUUSER.
        /// </summary>
        public const string MUUSER = "MUUSER";

        /// <summary>
        /// MUPID.
        /// </summary>
        public const string MUPID = "MUPID";

        /// <summary>
        /// MUJOBN.
        /// </summary>
        public const string MUJOBN = "MUJOBN";

        /// <summary>
        /// MUUPMJ.
        /// </summary>
        public const string MUUPMJ = "MUUPMJ";

        /// <summary>
        /// MUUPMT.
        /// </summary>
        public const string MUUPMT = "MUUPMT";

        /// <summary>
        /// MUFUSN6.
        /// </summary>
        public const string MUFUSN6 = "MUFUSN6";

        /// <summary>
        /// MUFUSN7.
        /// </summary>
        public const string MUFUSN7 = "MUFUSN7";

        /// <summary>
        /// MUFUSN8.
        /// </summary>
        public const string MUFUSN8 = "MUFUSN8";

        /// <summary>
        /// MUFUSS6.
        /// </summary>
        public const string MUFUSS6 = "MUFUSS6";

        /// <summary>
        /// MUFUSS7.
        /// </summary>
        public const string MUFUSS7 = "MUFUSS7";

        /// <summary>
        /// MUFUSS8.
        /// </summary>
        public const string MUFUSS8 = "MUFUSS8";

        /// <summary>
        /// MUFUSC6.
        /// </summary>
        public const string MUFUSC6 = "MUFUSC6";

        /// <summary>
        /// MUFUSC7.
        /// </summary>
        public const string MUFUSC7 = "MUFUSC7";

        /// <summary>
        /// MUFUSC8.
        /// </summary>
        public const string MUFUSC8 = "MUFUSC8";

        /// <summary>
        /// MUFUDATE6.
        /// </summary>
        public const string MUFUDATE6 = "MUFUDATE6";

        /// <summary>
        /// MUFUDATE7.
        /// </summary>
        public const string MUFUDATE7 = "MUFUDATE7";

        /// <summary>
        /// MUFUDATE8.
        /// </summary>
        public const string MUFUDATE8 = "MUFUDATE8";
    }

    /// <inheritdoc />
    public override string TableName => "F43061W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MUGPSP", "MUGPSP", JdeDataType.String, 2),
        new JdeField("MUUKID", "MUUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("MUMCU", "MUMCU", JdeDataType.String, 24, true, true),
        new JdeField("MUAN8", "MUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MUITM", "MUITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MUCATN", "MUCATN", JdeDataType.String, 16, true, true),
        new JdeField("MUCRCD", "MUCRCD", JdeDataType.String, 6, true, true),
        new JdeField("MUUOM", "MUUOM", JdeDataType.String, 4, true, true),
        new JdeField("MULITM", "MULITM", JdeDataType.String, 50),
        new JdeField("MUAITM", "MUAITM", JdeDataType.String, 50),
        new JdeField("MUPRRC", "MUPRRC", JdeDataType.Numeric),
        new JdeField("MUUORG", "MUUORG", JdeDataType.Numeric, null, true, true),
        new JdeField("MUEFTJ", "MUEFTJ", JdeDataType.Numeric),
        new JdeField("MUEXDJ", "MUEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MUUSER", "MUUSER", JdeDataType.String, 20),
        new JdeField("MUPID", "MUPID", JdeDataType.String, 20),
        new JdeField("MUJOBN", "MUJOBN", JdeDataType.String, 20),
        new JdeField("MUUPMJ", "MUUPMJ", JdeDataType.Numeric),
        new JdeField("MUUPMT", "MUUPMT", JdeDataType.Numeric),
        new JdeField("MUFUSN6", "MUFUSN6", JdeDataType.Numeric),
        new JdeField("MUFUSN7", "MUFUSN7", JdeDataType.Numeric),
        new JdeField("MUFUSN8", "MUFUSN8", JdeDataType.Numeric),
        new JdeField("MUFUSS6", "MUFUSS6", JdeDataType.String, 60),
        new JdeField("MUFUSS7", "MUFUSS7", JdeDataType.String, 60),
        new JdeField("MUFUSS8", "MUFUSS8", JdeDataType.String, 60),
        new JdeField("MUFUSC6", "MUFUSC6", JdeDataType.String, 2),
        new JdeField("MUFUSC7", "MUFUSC7", JdeDataType.String, 2),
        new JdeField("MUFUSC8", "MUFUSC8", JdeDataType.String, 2),
        new JdeField("MUFUDATE6", "MUFUDATE6", JdeDataType.Numeric),
        new JdeField("MUFUDATE7", "MUFUDATE7", JdeDataType.Numeric),
        new JdeField("MUFUDATE8", "MUFUDATE8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43061W_0", "Primary Key on MUUKID, MUMCU, MUAN8, MUITM, MUCATN, MUCRCD, MUUOM, MUUORG, MUEXDJ", new[] { "MUUKID", "MUMCU", "MUAN8", "MUITM", "MUCATN", "MUCRCD", "MUUOM", "MUUORG", "MUEXDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
