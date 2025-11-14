using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI017 - .
/// </summary>
public class F09UI017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FWUSER.
        /// </summary>
        public const string FWUSER = "FWUSER";

        /// <summary>
        /// FWUPMJ.
        /// </summary>
        public const string FWUPMJ = "FWUPMJ";

        /// <summary>
        /// FWUPMT.
        /// </summary>
        public const string FWUPMT = "FWUPMT";

        /// <summary>
        /// FWJOBS.
        /// </summary>
        public const string FWJOBS = "FWJOBS";

        /// <summary>
        /// FWRSTRUC.
        /// </summary>
        public const string FWRSTRUC = "FWRSTRUC";

        /// <summary>
        /// FWJELN.
        /// </summary>
        public const string FWJELN = "FWJELN";

        /// <summary>
        /// FWCSHTYP.
        /// </summary>
        public const string FWCSHTYP = "FWCSHTYP";

        /// <summary>
        /// FWBNKAID.
        /// </summary>
        public const string FWBNKAID = "FWBNKAID";

        /// <summary>
        /// FWBCRC.
        /// </summary>
        public const string FWBCRC = "FWBCRC";

        /// <summary>
        /// FWRECTYPE.
        /// </summary>
        public const string FWRECTYPE = "FWRECTYPE";

        /// <summary>
        /// FWSRCSYS.
        /// </summary>
        public const string FWSRCSYS = "FWSRCSYS";

        /// <summary>
        /// FWLEVEL.
        /// </summary>
        public const string FWLEVEL = "FWLEVEL";

        /// <summary>
        /// FWSEQUEN.
        /// </summary>
        public const string FWSEQUEN = "FWSEQUEN";

        /// <summary>
        /// FWPNTCSH.
        /// </summary>
        public const string FWPNTCSH = "FWPNTCSH";

        /// <summary>
        /// FWPDPROC.
        /// </summary>
        public const string FWPDPROC = "FWPDPROC";

        /// <summary>
        /// FWDL01.
        /// </summary>
        public const string FWDL01 = "FWDL01";

        /// <summary>
        /// FWPDCATG.
        /// </summary>
        public const string FWPDCATG = "FWPDCATG";

        /// <summary>
        /// FWCO.
        /// </summary>
        public const string FWCO = "FWCO";

        /// <summary>
        /// FWMCU.
        /// </summary>
        public const string FWMCU = "FWMCU";

        /// <summary>
        /// FWOBJ.
        /// </summary>
        public const string FWOBJ = "FWOBJ";

        /// <summary>
        /// FWSUB.
        /// </summary>
        public const string FWSUB = "FWSUB";

        /// <summary>
        /// FWWGHTNO.
        /// </summary>
        public const string FWWGHTNO = "FWWGHTNO";

        /// <summary>
        /// FWNDCRCD.
        /// </summary>
        public const string FWNDCRCD = "FWNDCRCD";

        /// <summary>
        /// FWRCRD.
        /// </summary>
        public const string FWRCRD = "FWRCRD";

        /// <summary>
        /// FWCAD.
        /// </summary>
        public const string FWCAD = "FWCAD";

        /// <summary>
        /// FWFTR.
        /// </summary>
        public const string FWFTR = "FWFTR";

        /// <summary>
        /// FWAMTA.
        /// </summary>
        public const string FWAMTA = "FWAMTA";

        /// <summary>
        /// FWAMTADJ.
        /// </summary>
        public const string FWAMTADJ = "FWAMTADJ";

        /// <summary>
        /// FWAN01.
        /// </summary>
        public const string FWAN01 = "FWAN01";

        /// <summary>
        /// FWBA01.
        /// </summary>
        public const string FWBA01 = "FWBA01";

        /// <summary>
        /// FWAN02.
        /// </summary>
        public const string FWAN02 = "FWAN02";

        /// <summary>
        /// FWBA02.
        /// </summary>
        public const string FWBA02 = "FWBA02";

        /// <summary>
        /// FWAN03.
        /// </summary>
        public const string FWAN03 = "FWAN03";

        /// <summary>
        /// FWBA03.
        /// </summary>
        public const string FWBA03 = "FWBA03";

        /// <summary>
        /// FWAN04.
        /// </summary>
        public const string FWAN04 = "FWAN04";

        /// <summary>
        /// FWBA04.
        /// </summary>
        public const string FWBA04 = "FWBA04";

        /// <summary>
        /// FWAN05.
        /// </summary>
        public const string FWAN05 = "FWAN05";

        /// <summary>
        /// FWBA05.
        /// </summary>
        public const string FWBA05 = "FWBA05";

        /// <summary>
        /// FWAN06.
        /// </summary>
        public const string FWAN06 = "FWAN06";

        /// <summary>
        /// FWBA06.
        /// </summary>
        public const string FWBA06 = "FWBA06";

        /// <summary>
        /// FWAN07.
        /// </summary>
        public const string FWAN07 = "FWAN07";

        /// <summary>
        /// FWBA07.
        /// </summary>
        public const string FWBA07 = "FWBA07";

        /// <summary>
        /// FWBSTN.
        /// </summary>
        public const string FWBSTN = "FWBSTN";

        /// <summary>
        /// FWSTMD.
        /// </summary>
        public const string FWSTMD = "FWSTMD";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FWUSER", "FWUSER", JdeDataType.String, 20, true, true),
        new JdeField("FWUPMJ", "FWUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FWUPMT", "FWUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("FWJOBS", "FWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("FWRSTRUC", "FWRSTRUC", JdeDataType.String, 20, true, true),
        new JdeField("FWJELN", "FWJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("FWCSHTYP", "FWCSHTYP", JdeDataType.String, 20, true, true),
        new JdeField("FWBNKAID", "FWBNKAID", JdeDataType.String, 16, true, true),
        new JdeField("FWBCRC", "FWBCRC", JdeDataType.String, 6),
        new JdeField("FWRECTYPE", "FWRECTYPE", JdeDataType.String, 2),
        new JdeField("FWSRCSYS", "FWSRCSYS", JdeDataType.String, 8),
        new JdeField("FWLEVEL", "FWLEVEL", JdeDataType.Numeric),
        new JdeField("FWSEQUEN", "FWSEQUEN", JdeDataType.Numeric),
        new JdeField("FWPNTCSH", "FWPNTCSH", JdeDataType.String, 20),
        new JdeField("FWPDPROC", "FWPDPROC", JdeDataType.String, 2),
        new JdeField("FWDL01", "FWDL01", JdeDataType.String, 60),
        new JdeField("FWPDCATG", "FWPDCATG", JdeDataType.String, 2),
        new JdeField("FWCO", "FWCO", JdeDataType.String, 10),
        new JdeField("FWMCU", "FWMCU", JdeDataType.String, 24),
        new JdeField("FWOBJ", "FWOBJ", JdeDataType.String, 12),
        new JdeField("FWSUB", "FWSUB", JdeDataType.String, 16),
        new JdeField("FWWGHTNO", "FWWGHTNO", JdeDataType.Numeric),
        new JdeField("FWNDCRCD", "FWNDCRCD", JdeDataType.String, 6),
        new JdeField("FWRCRD", "FWRCRD", JdeDataType.String, 6),
        new JdeField("FWCAD", "FWCAD", JdeDataType.Numeric),
        new JdeField("FWFTR", "FWFTR", JdeDataType.Numeric),
        new JdeField("FWAMTA", "FWAMTA", JdeDataType.Numeric),
        new JdeField("FWAMTADJ", "FWAMTADJ", JdeDataType.Numeric),
        new JdeField("FWAN01", "FWAN01", JdeDataType.Numeric),
        new JdeField("FWBA01", "FWBA01", JdeDataType.Numeric),
        new JdeField("FWAN02", "FWAN02", JdeDataType.Numeric),
        new JdeField("FWBA02", "FWBA02", JdeDataType.Numeric),
        new JdeField("FWAN03", "FWAN03", JdeDataType.Numeric),
        new JdeField("FWBA03", "FWBA03", JdeDataType.Numeric),
        new JdeField("FWAN04", "FWAN04", JdeDataType.Numeric),
        new JdeField("FWBA04", "FWBA04", JdeDataType.Numeric),
        new JdeField("FWAN05", "FWAN05", JdeDataType.Numeric),
        new JdeField("FWBA05", "FWBA05", JdeDataType.Numeric),
        new JdeField("FWAN06", "FWAN06", JdeDataType.Numeric),
        new JdeField("FWBA06", "FWBA06", JdeDataType.Numeric),
        new JdeField("FWAN07", "FWAN07", JdeDataType.Numeric),
        new JdeField("FWBA07", "FWBA07", JdeDataType.Numeric),
        new JdeField("FWBSTN", "FWBSTN", JdeDataType.Numeric),
        new JdeField("FWSTMD", "FWSTMD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI017_0", "Primary Key on FWUSER, FWUPMJ, FWUPMT, FWJOBS, FWRSTRUC, FWJELN, FWCSHTYP, FWBNKAID", new[] { "FWUSER", "FWUPMJ", "FWUPMT", "FWJOBS", "FWRSTRUC", "FWJELN", "FWCSHTYP", "FWBNKAID" }, isUnique: true, isPrimaryKey: true)
    };
}
