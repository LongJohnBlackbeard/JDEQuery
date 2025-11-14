using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08401 - .
/// </summary>
public class F08401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HAAN8.
        /// </summary>
        public const string HAAN8 = "HAAN8";

        /// <summary>
        /// HAALPH.
        /// </summary>
        public const string HAALPH = "HAALPH";

        /// <summary>
        /// HAAPS.
        /// </summary>
        public const string HAAPS = "HAAPS";

        /// <summary>
        /// HASSN.
        /// </summary>
        public const string HASSN = "HASSN";

        /// <summary>
        /// HAMCU.
        /// </summary>
        public const string HAMCU = "HAMCU";

        /// <summary>
        /// HAPOS.
        /// </summary>
        public const string HAPOS = "HAPOS";

        /// <summary>
        /// HAJBCD.
        /// </summary>
        public const string HAJBCD = "HAJBCD";

        /// <summary>
        /// HAJBST.
        /// </summary>
        public const string HAJBST = "HAJBST";

        /// <summary>
        /// HAEEOJ.
        /// </summary>
        public const string HAEEOJ = "HAEEOJ";

        /// <summary>
        /// HAEEOM.
        /// </summary>
        public const string HAEEOM = "HAEEOM";

        /// <summary>
        /// HASEX.
        /// </summary>
        public const string HASEX = "HASEX";

        /// <summary>
        /// HAHM01.
        /// </summary>
        public const string HAHM01 = "HAHM01";

        /// <summary>
        /// HAHM02.
        /// </summary>
        public const string HAHM02 = "HAHM02";

        /// <summary>
        /// HAHM03.
        /// </summary>
        public const string HAHM03 = "HAHM03";

        /// <summary>
        /// HAHM04.
        /// </summary>
        public const string HAHM04 = "HAHM04";

        /// <summary>
        /// HAHM05.
        /// </summary>
        public const string HAHM05 = "HAHM05";

        /// <summary>
        /// HAHM06.
        /// </summary>
        public const string HAHM06 = "HAHM06";

        /// <summary>
        /// HAHM07.
        /// </summary>
        public const string HAHM07 = "HAHM07";

        /// <summary>
        /// HAHM08.
        /// </summary>
        public const string HAHM08 = "HAHM08";

        /// <summary>
        /// HAHM09.
        /// </summary>
        public const string HAHM09 = "HAHM09";

        /// <summary>
        /// HAHM10.
        /// </summary>
        public const string HAHM10 = "HAHM10";

        /// <summary>
        /// HAHN01.
        /// </summary>
        public const string HAHN01 = "HAHN01";

        /// <summary>
        /// HAHN02.
        /// </summary>
        public const string HAHN02 = "HAHN02";

        /// <summary>
        /// HAHN03.
        /// </summary>
        public const string HAHN03 = "HAHN03";

        /// <summary>
        /// HAHN04.
        /// </summary>
        public const string HAHN04 = "HAHN04";

        /// <summary>
        /// HAHN05.
        /// </summary>
        public const string HAHN05 = "HAHN05";

        /// <summary>
        /// HAHN06.
        /// </summary>
        public const string HAHN06 = "HAHN06";

        /// <summary>
        /// HAHN07.
        /// </summary>
        public const string HAHN07 = "HAHN07";

        /// <summary>
        /// HAHN08.
        /// </summary>
        public const string HAHN08 = "HAHN08";

        /// <summary>
        /// HAHN09.
        /// </summary>
        public const string HAHN09 = "HAHN09";

        /// <summary>
        /// HAHN10.
        /// </summary>
        public const string HAHN10 = "HAHN10";

        /// <summary>
        /// HADOB.
        /// </summary>
        public const string HADOB = "HADOB";

        /// <summary>
        /// HARECB.
        /// </summary>
        public const string HARECB = "HARECB";

        /// <summary>
        /// HARECE.
        /// </summary>
        public const string HARECE = "HARECE";

        /// <summary>
        /// HADFIN.
        /// </summary>
        public const string HADFIN = "HADFIN";

        /// <summary>
        /// HADTAV.
        /// </summary>
        public const string HADTAV = "HADTAV";

        /// <summary>
        /// HASALA.
        /// </summary>
        public const string HASALA = "HASALA";

        /// <summary>
        /// HAHRA.
        /// </summary>
        public const string HAHRA = "HAHRA";

        /// <summary>
        /// HAUSER.
        /// </summary>
        public const string HAUSER = "HAUSER";

        /// <summary>
        /// HAPID.
        /// </summary>
        public const string HAPID = "HAPID";

        /// <summary>
        /// HAUPMJ.
        /// </summary>
        public const string HAUPMJ = "HAUPMJ";

        /// <summary>
        /// HAJOBN.
        /// </summary>
        public const string HAJOBN = "HAJOBN";

        /// <summary>
        /// HAHMCU.
        /// </summary>
        public const string HAHMCU = "HAHMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F08401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HAAN8", "HAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HAALPH", "HAALPH", JdeDataType.String, 80),
        new JdeField("HAAPS", "HAAPS", JdeDataType.String, 4),
        new JdeField("HASSN", "HASSN", JdeDataType.String, 40),
        new JdeField("HAMCU", "HAMCU", JdeDataType.String, 24),
        new JdeField("HAPOS", "HAPOS", JdeDataType.String, 16),
        new JdeField("HAJBCD", "HAJBCD", JdeDataType.String, 12),
        new JdeField("HAJBST", "HAJBST", JdeDataType.String, 8),
        new JdeField("HAEEOJ", "HAEEOJ", JdeDataType.String, 6),
        new JdeField("HAEEOM", "HAEEOM", JdeDataType.String, 4),
        new JdeField("HASEX", "HASEX", JdeDataType.String, 2),
        new JdeField("HAHM01", "HAHM01", JdeDataType.String, 2),
        new JdeField("HAHM02", "HAHM02", JdeDataType.String, 2),
        new JdeField("HAHM03", "HAHM03", JdeDataType.String, 2),
        new JdeField("HAHM04", "HAHM04", JdeDataType.String, 2),
        new JdeField("HAHM05", "HAHM05", JdeDataType.String, 2),
        new JdeField("HAHM06", "HAHM06", JdeDataType.String, 2),
        new JdeField("HAHM07", "HAHM07", JdeDataType.String, 2),
        new JdeField("HAHM08", "HAHM08", JdeDataType.String, 2),
        new JdeField("HAHM09", "HAHM09", JdeDataType.String, 2),
        new JdeField("HAHM10", "HAHM10", JdeDataType.String, 2),
        new JdeField("HAHN01", "HAHN01", JdeDataType.String, 6),
        new JdeField("HAHN02", "HAHN02", JdeDataType.String, 6),
        new JdeField("HAHN03", "HAHN03", JdeDataType.String, 6),
        new JdeField("HAHN04", "HAHN04", JdeDataType.String, 6),
        new JdeField("HAHN05", "HAHN05", JdeDataType.String, 6),
        new JdeField("HAHN06", "HAHN06", JdeDataType.String, 6),
        new JdeField("HAHN07", "HAHN07", JdeDataType.String, 6),
        new JdeField("HAHN08", "HAHN08", JdeDataType.String, 6),
        new JdeField("HAHN09", "HAHN09", JdeDataType.String, 6),
        new JdeField("HAHN10", "HAHN10", JdeDataType.String, 6),
        new JdeField("HADOB", "HADOB", JdeDataType.Numeric),
        new JdeField("HARECB", "HARECB", JdeDataType.Numeric),
        new JdeField("HARECE", "HARECE", JdeDataType.Numeric),
        new JdeField("HADFIN", "HADFIN", JdeDataType.Numeric),
        new JdeField("HADTAV", "HADTAV", JdeDataType.Numeric),
        new JdeField("HASALA", "HASALA", JdeDataType.Numeric),
        new JdeField("HAHRA", "HAHRA", JdeDataType.Numeric),
        new JdeField("HAUSER", "HAUSER", JdeDataType.String, 20),
        new JdeField("HAPID", "HAPID", JdeDataType.String, 20),
        new JdeField("HAUPMJ", "HAUPMJ", JdeDataType.Numeric),
        new JdeField("HAJOBN", "HAJOBN", JdeDataType.String, 20),
        new JdeField("HAHMCU", "HAHMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08401_0", "Primary Key on HAAN8", new[] { "HAAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08401_2", "Index on HASSN", new[] { "HASSN" })
    };
}
