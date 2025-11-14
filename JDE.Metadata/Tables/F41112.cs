using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41112 - .
/// </summary>
public class F41112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INDCT.
        /// </summary>
        public const string INDCT = "INDCT";

        /// <summary>
        /// INFY.
        /// </summary>
        public const string INFY = "INFY";

        /// <summary>
        /// INCTRY.
        /// </summary>
        public const string INCTRY = "INCTRY";

        /// <summary>
        /// INITM.
        /// </summary>
        public const string INITM = "INITM";

        /// <summary>
        /// INLITM.
        /// </summary>
        public const string INLITM = "INLITM";

        /// <summary>
        /// INAITM.
        /// </summary>
        public const string INAITM = "INAITM";

        /// <summary>
        /// INMCU.
        /// </summary>
        public const string INMCU = "INMCU";

        /// <summary>
        /// INLOCN.
        /// </summary>
        public const string INLOCN = "INLOCN";

        /// <summary>
        /// INLOTN.
        /// </summary>
        public const string INLOTN = "INLOTN";

        /// <summary>
        /// INGLPT.
        /// </summary>
        public const string INGLPT = "INGLPT";

        /// <summary>
        /// INAN8.
        /// </summary>
        public const string INAN8 = "INAN8";

        /// <summary>
        /// INSHAN.
        /// </summary>
        public const string INSHAN = "INSHAN";

        /// <summary>
        /// INNQ01.
        /// </summary>
        public const string INNQ01 = "INNQ01";

        /// <summary>
        /// INNQ02.
        /// </summary>
        public const string INNQ02 = "INNQ02";

        /// <summary>
        /// INNQ03.
        /// </summary>
        public const string INNQ03 = "INNQ03";

        /// <summary>
        /// INNQ04.
        /// </summary>
        public const string INNQ04 = "INNQ04";

        /// <summary>
        /// INNQ05.
        /// </summary>
        public const string INNQ05 = "INNQ05";

        /// <summary>
        /// INNQ06.
        /// </summary>
        public const string INNQ06 = "INNQ06";

        /// <summary>
        /// INNQ07.
        /// </summary>
        public const string INNQ07 = "INNQ07";

        /// <summary>
        /// INNQ08.
        /// </summary>
        public const string INNQ08 = "INNQ08";

        /// <summary>
        /// INNQ09.
        /// </summary>
        public const string INNQ09 = "INNQ09";

        /// <summary>
        /// INNQ10.
        /// </summary>
        public const string INNQ10 = "INNQ10";

        /// <summary>
        /// INNQ11.
        /// </summary>
        public const string INNQ11 = "INNQ11";

        /// <summary>
        /// INNQ12.
        /// </summary>
        public const string INNQ12 = "INNQ12";

        /// <summary>
        /// INNQ13.
        /// </summary>
        public const string INNQ13 = "INNQ13";

        /// <summary>
        /// INNQ14.
        /// </summary>
        public const string INNQ14 = "INNQ14";

        /// <summary>
        /// INAN01.
        /// </summary>
        public const string INAN01 = "INAN01";

        /// <summary>
        /// INAN02.
        /// </summary>
        public const string INAN02 = "INAN02";

        /// <summary>
        /// INAN03.
        /// </summary>
        public const string INAN03 = "INAN03";

        /// <summary>
        /// INAN04.
        /// </summary>
        public const string INAN04 = "INAN04";

        /// <summary>
        /// INAN05.
        /// </summary>
        public const string INAN05 = "INAN05";

        /// <summary>
        /// INAN06.
        /// </summary>
        public const string INAN06 = "INAN06";

        /// <summary>
        /// INAN07.
        /// </summary>
        public const string INAN07 = "INAN07";

        /// <summary>
        /// INAN08.
        /// </summary>
        public const string INAN08 = "INAN08";

        /// <summary>
        /// INAN09.
        /// </summary>
        public const string INAN09 = "INAN09";

        /// <summary>
        /// INAN10.
        /// </summary>
        public const string INAN10 = "INAN10";

        /// <summary>
        /// INAN11.
        /// </summary>
        public const string INAN11 = "INAN11";

        /// <summary>
        /// INAN12.
        /// </summary>
        public const string INAN12 = "INAN12";

        /// <summary>
        /// INAN13.
        /// </summary>
        public const string INAN13 = "INAN13";

        /// <summary>
        /// INAN14.
        /// </summary>
        public const string INAN14 = "INAN14";

        /// <summary>
        /// INCUMA.
        /// </summary>
        public const string INCUMA = "INCUMA";

        /// <summary>
        /// INCMQT.
        /// </summary>
        public const string INCMQT = "INCMQT";

        /// <summary>
        /// INAISL.
        /// </summary>
        public const string INAISL = "INAISL";

        /// <summary>
        /// INBIN.
        /// </summary>
        public const string INBIN = "INBIN";

        /// <summary>
        /// INTDAY.
        /// </summary>
        public const string INTDAY = "INTDAY";

        /// <summary>
        /// INUSER.
        /// </summary>
        public const string INUSER = "INUSER";

        /// <summary>
        /// INPID.
        /// </summary>
        public const string INPID = "INPID";

        /// <summary>
        /// INUPMJ.
        /// </summary>
        public const string INUPMJ = "INUPMJ";

        /// <summary>
        /// INJOBN.
        /// </summary>
        public const string INJOBN = "INJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F41112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INDCT", "INDCT", JdeDataType.String, 4, true, true),
        new JdeField("INFY", "INFY", JdeDataType.Numeric, null, true, true),
        new JdeField("INCTRY", "INCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("INITM", "INITM", JdeDataType.Numeric, null, true, true),
        new JdeField("INLITM", "INLITM", JdeDataType.String, 50),
        new JdeField("INAITM", "INAITM", JdeDataType.String, 50),
        new JdeField("INMCU", "INMCU", JdeDataType.String, 24, true, true),
        new JdeField("INLOCN", "INLOCN", JdeDataType.String, 40, true, true),
        new JdeField("INLOTN", "INLOTN", JdeDataType.String, 60, true, true),
        new JdeField("INGLPT", "INGLPT", JdeDataType.String, 8, true, true),
        new JdeField("INAN8", "INAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("INSHAN", "INSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("INNQ01", "INNQ01", JdeDataType.Numeric),
        new JdeField("INNQ02", "INNQ02", JdeDataType.Numeric),
        new JdeField("INNQ03", "INNQ03", JdeDataType.Numeric),
        new JdeField("INNQ04", "INNQ04", JdeDataType.Numeric),
        new JdeField("INNQ05", "INNQ05", JdeDataType.Numeric),
        new JdeField("INNQ06", "INNQ06", JdeDataType.Numeric),
        new JdeField("INNQ07", "INNQ07", JdeDataType.Numeric),
        new JdeField("INNQ08", "INNQ08", JdeDataType.Numeric),
        new JdeField("INNQ09", "INNQ09", JdeDataType.Numeric),
        new JdeField("INNQ10", "INNQ10", JdeDataType.Numeric),
        new JdeField("INNQ11", "INNQ11", JdeDataType.Numeric),
        new JdeField("INNQ12", "INNQ12", JdeDataType.Numeric),
        new JdeField("INNQ13", "INNQ13", JdeDataType.Numeric),
        new JdeField("INNQ14", "INNQ14", JdeDataType.Numeric),
        new JdeField("INAN01", "INAN01", JdeDataType.Numeric),
        new JdeField("INAN02", "INAN02", JdeDataType.Numeric),
        new JdeField("INAN03", "INAN03", JdeDataType.Numeric),
        new JdeField("INAN04", "INAN04", JdeDataType.Numeric),
        new JdeField("INAN05", "INAN05", JdeDataType.Numeric),
        new JdeField("INAN06", "INAN06", JdeDataType.Numeric),
        new JdeField("INAN07", "INAN07", JdeDataType.Numeric),
        new JdeField("INAN08", "INAN08", JdeDataType.Numeric),
        new JdeField("INAN09", "INAN09", JdeDataType.Numeric),
        new JdeField("INAN10", "INAN10", JdeDataType.Numeric),
        new JdeField("INAN11", "INAN11", JdeDataType.Numeric),
        new JdeField("INAN12", "INAN12", JdeDataType.Numeric),
        new JdeField("INAN13", "INAN13", JdeDataType.Numeric),
        new JdeField("INAN14", "INAN14", JdeDataType.Numeric),
        new JdeField("INCUMA", "INCUMA", JdeDataType.Numeric),
        new JdeField("INCMQT", "INCMQT", JdeDataType.Numeric),
        new JdeField("INAISL", "INAISL", JdeDataType.String, 16),
        new JdeField("INBIN", "INBIN", JdeDataType.String, 16),
        new JdeField("INTDAY", "INTDAY", JdeDataType.Numeric),
        new JdeField("INUSER", "INUSER", JdeDataType.String, 20),
        new JdeField("INPID", "INPID", JdeDataType.String, 20),
        new JdeField("INUPMJ", "INUPMJ", JdeDataType.Numeric),
        new JdeField("INJOBN", "INJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41112_0", "Primary Key on INDCT, INFY, INCTRY, INITM, INMCU, INLOCN, INLOTN, INGLPT, INAN8, INSHAN", new[] { "INDCT", "INFY", "INCTRY", "INITM", "INMCU", "INLOCN", "INLOTN", "INGLPT", "INAN8", "INSHAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41112_2", "Index on INDCT, INITM, INMCU, INLOCN, INLOTN, INGLPT, INFY, INCTRY", new[] { "INDCT", "INITM", "INMCU", "INLOCN", "INLOTN", "INGLPT", "INFY", "INCTRY" })
    };
}
