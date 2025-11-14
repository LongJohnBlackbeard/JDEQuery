using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08040 - .
/// </summary>
public class F08040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JTDTAL.
        /// </summary>
        public const string JTDTAL = "JTDTAL";

        /// <summary>
        /// JTHRSS.
        /// </summary>
        public const string JTHRSS = "JTHRSS";

        /// <summary>
        /// JTEMPH.
        /// </summary>
        public const string JTEMPH = "JTEMPH";

        /// <summary>
        /// JTEH01.
        /// </summary>
        public const string JTEH01 = "JTEH01";

        /// <summary>
        /// JTEH02.
        /// </summary>
        public const string JTEH02 = "JTEH02";

        /// <summary>
        /// JTEH03.
        /// </summary>
        public const string JTEH03 = "JTEH03";

        /// <summary>
        /// JTEH04.
        /// </summary>
        public const string JTEH04 = "JTEH04";

        /// <summary>
        /// JTEH05.
        /// </summary>
        public const string JTEH05 = "JTEH05";

        /// <summary>
        /// JTEH06.
        /// </summary>
        public const string JTEH06 = "JTEH06";

        /// <summary>
        /// JTEH07.
        /// </summary>
        public const string JTEH07 = "JTEH07";

        /// <summary>
        /// JTEH08.
        /// </summary>
        public const string JTEH08 = "JTEH08";

        /// <summary>
        /// JTEH09.
        /// </summary>
        public const string JTEH09 = "JTEH09";

        /// <summary>
        /// JTEH10.
        /// </summary>
        public const string JTEH10 = "JTEH10";

        /// <summary>
        /// JTUSER.
        /// </summary>
        public const string JTUSER = "JTUSER";

        /// <summary>
        /// JTPID.
        /// </summary>
        public const string JTPID = "JTPID";

        /// <summary>
        /// JTUPMJ.
        /// </summary>
        public const string JTUPMJ = "JTUPMJ";

        /// <summary>
        /// JTJOBN.
        /// </summary>
        public const string JTJOBN = "JTJOBN";

        /// <summary>
        /// JTFLXC.
        /// </summary>
        public const string JTFLXC = "JTFLXC";

        /// <summary>
        /// JTYORN.
        /// </summary>
        public const string JTYORN = "JTYORN";

        /// <summary>
        /// JTPRSR.
        /// </summary>
        public const string JTPRSR = "JTPRSR";

        /// <summary>
        /// JTSPRS.
        /// </summary>
        public const string JTSPRS = "JTSPRS";

        /// <summary>
        /// JTPBF1.
        /// </summary>
        public const string JTPBF1 = "JTPBF1";

        /// <summary>
        /// JTPBF2.
        /// </summary>
        public const string JTPBF2 = "JTPBF2";

        /// <summary>
        /// JTPBF3.
        /// </summary>
        public const string JTPBF3 = "JTPBF3";

        /// <summary>
        /// JTPBF4.
        /// </summary>
        public const string JTPBF4 = "JTPBF4";

        /// <summary>
        /// JTPRF1.
        /// </summary>
        public const string JTPRF1 = "JTPRF1";

        /// <summary>
        /// JTSDFS.
        /// </summary>
        public const string JTSDFS = "JTSDFS";

        /// <summary>
        /// JTSIP.
        /// </summary>
        public const string JTSIP = "JTSIP";

        /// <summary>
        /// JTSALD.
        /// </summary>
        public const string JTSALD = "JTSALD";

        /// <summary>
        /// JTMNZ1.
        /// </summary>
        public const string JTMNZ1 = "JTMNZ1";

        /// <summary>
        /// JTEDETCR.
        /// </summary>
        public const string JTEDETCR = "JTEDETCR";
    }

    /// <inheritdoc />
    public override string TableName => "F08040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JTDTAL", "JTDTAL", JdeDataType.String, 20, true, true),
        new JdeField("JTHRSS", "JTHRSS", JdeDataType.String, 20, true, true),
        new JdeField("JTEMPH", "JTEMPH", JdeDataType.String, 2),
        new JdeField("JTEH01", "JTEH01", JdeDataType.String, 2),
        new JdeField("JTEH02", "JTEH02", JdeDataType.String, 2),
        new JdeField("JTEH03", "JTEH03", JdeDataType.String, 2),
        new JdeField("JTEH04", "JTEH04", JdeDataType.String, 2),
        new JdeField("JTEH05", "JTEH05", JdeDataType.String, 2),
        new JdeField("JTEH06", "JTEH06", JdeDataType.String, 2),
        new JdeField("JTEH07", "JTEH07", JdeDataType.String, 2),
        new JdeField("JTEH08", "JTEH08", JdeDataType.String, 2),
        new JdeField("JTEH09", "JTEH09", JdeDataType.String, 2),
        new JdeField("JTEH10", "JTEH10", JdeDataType.String, 2),
        new JdeField("JTUSER", "JTUSER", JdeDataType.String, 20),
        new JdeField("JTPID", "JTPID", JdeDataType.String, 20),
        new JdeField("JTUPMJ", "JTUPMJ", JdeDataType.Numeric),
        new JdeField("JTJOBN", "JTJOBN", JdeDataType.String, 20),
        new JdeField("JTFLXC", "JTFLXC", JdeDataType.Numeric),
        new JdeField("JTYORN", "JTYORN", JdeDataType.String, 2),
        new JdeField("JTPRSR", "JTPRSR", JdeDataType.String, 2),
        new JdeField("JTSPRS", "JTSPRS", JdeDataType.String, 2),
        new JdeField("JTPBF1", "JTPBF1", JdeDataType.String, 2),
        new JdeField("JTPBF2", "JTPBF2", JdeDataType.String, 2),
        new JdeField("JTPBF3", "JTPBF3", JdeDataType.String, 2),
        new JdeField("JTPBF4", "JTPBF4", JdeDataType.String, 2),
        new JdeField("JTPRF1", "JTPRF1", JdeDataType.String, 2),
        new JdeField("JTSDFS", "JTSDFS", JdeDataType.String, 2),
        new JdeField("JTSIP", "JTSIP", JdeDataType.String, 2),
        new JdeField("JTSALD", "JTSALD", JdeDataType.String, 2),
        new JdeField("JTMNZ1", "JTMNZ1", JdeDataType.String, 2),
        new JdeField("JTEDETCR", "JTEDETCR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08040_0", "Primary Key on JTDTAL, JTHRSS", new[] { "JTDTAL", "JTHRSS" }, isUnique: true, isPrimaryKey: true)
    };
}
